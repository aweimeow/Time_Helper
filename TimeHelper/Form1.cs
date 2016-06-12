using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
////Using WinAPI
using System.Runtime.InteropServices;
using System.IO;
////Using Metro UI
using MetroFramework.Forms;
////Using Regex
using System.Text.RegularExpressions;
////Using Json
using Newtonsoft.Json;
////Using Encrypt - MD5
using System.Security.Cryptography;
////Using to draw Chart
using System.Windows.Forms.DataVisualization.Charting;

namespace TimeHelper
{
	public partial class Form1 : MetroForm
	{
		#region Data Use Struct
		public class SettingData
		{
			public String LogLocation { get; set; }
			public int RecordSpeed { get; set; }
			public bool RegularEnable { get; set; }
			public int RegularAlarmTime { get; set; }
			public String RegularAlarmMsg { get; set; }
			public bool CleanLogEnable { get; set; }
			public int CleanLogTime { get; set; }
			public int AutoUpdateSpeed { get; set; }
			/**	LocLocation - 記錄檔位置
			 *	RecordSpeed - 紀錄速度間隔 (20 sec ~ 120 sec)
			 *  RegularEnable - 啟用定時鬧鐘
			 *  RegularAlarmTime - 定時鬧鐘間隔
			 *  RegularAlarmMsg - 定時鬧鐘提醒訊息
			 *  CleanLogEnable - 定時清除記錄檔
			 *  CleanLogTime - 保留幾天內的記錄檔
			 *  AutoUpdateSpeed - 自動更新頻率
			 * **/
		}
		public class LogData
		{
			//紀錄檔用的Struct
			public DateTime date { get; set; }
			public String APP { get; set; }
			public String OtherInformation { get; set; }
		}
		public class ChartData
		{
			//統計圖表用的Struct
			public String AppName { get; set; }
			public int Count { get; set; }
		}
		public class TodoData
		{
			// TODO List's data structure
			public int id { get; set; }
			public String name { get; set; }
			public DateTime date { get; set; }
			public Boolean is_done { get; set; }
		}
		#endregion
		#region Global Variable
		HookFunction hook = new HookFunction();
		private String NowTime = "";		//現在時間
		private String path = "";			//Log檔路徑
		private String WriteInData = "";	//要寫入的資料
		private List<LogData> Log = new List<LogData>();//A List Contain Log
		private List<ChartData> StaticsData = new List<ChartData>();//A List to Count the mount of APP's use
		private int LogDataIndex = -1;	//紀錄Log<List>內中的索引
		private int fileLine = -1;		//紀錄目前log檔內已經寫了幾行
		private List<TodoData> todolist = new List<TodoData>(); // Record now's todo data
		#endregion
		public Form1()
		{
			InitializeComponent();
		}
		#region 紀錄間隔時間 - 橫條bar 拉動
		private void metroTrackBar_Speed_Scroll(object sender, ScrollEventArgs e)
		{
			lbl_DataSec.Text = metroTrackBar_Speed.Value + " 秒";
			Timer_GetData.Interval = metroTrackBar_Speed.Value * 1000;
		}
		#endregion
		#region Click Event
		//Btn Start & Stop >> 測試用按鈕，之後會自動啟用
		private void Btn_Start_Click(object sender, EventArgs e)
		{
			if(Btn_LogLoc.Text == String.Empty)
			{
				MetroFramework.MetroMessageBox.Show(this, "\n請務必記得設定紀錄檔路徑，否則沒辦法記錄下來您的一舉一動哦~\n若是太常遇到這個問題，請洽開發人員，謝謝", "未設定紀錄檔路徑", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				Timer_GetData.Enabled = true;
				MTC.SelectedIndex = 0;
				path = Btn_LogLoc.Text;
				if(File.Exists(path))
				{
					if (fileLine == -1)
						fileLine = GetTotalLineCount(path);
				}
			}
		}
		private void Btn_Stop_Click(object sender, EventArgs e)
		{
			Timer_GetData.Enabled = false;
		}
		//Btn_LogLoc_Click >> 選擇紀錄檔路徑
		private void Btn_LogLoc_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog path = new FolderBrowserDialog();
			path.ShowDialog();
			if (path.SelectedPath != String.Empty)
				Btn_LogLoc.Text = path.SelectedPath + "\\TimeHelper.log";
		}
		private void Btn_addtodo_Click(object sender, EventArgs e)
		{
			TodoData todo = new TodoData();
			todo.id = CLB_TODO.Items.Count;
			todo.name = TB_addtodo.Text;
			todo.date = DateTime.Now;
			todo.is_done = false;
			todolist.Add(todo);
			flushTODOList();
		}
		private void MTC_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (MTC.SelectedIndex == 0)
			{
				if(File.Exists(path))
				{
					DoingData();
					DrawChart();
				}
			}
		}
		
		#endregion
		#region TODO List Function
		private void flushTODOList()
		{
			CLB_TODO.Items.Clear();
			foreach(TodoData todo in todolist)
			{
				CLB_TODO.Items.Add(todo.name);
			}
		}

		private void CLB_TODO_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			for(int i = 0; i < CLB_TODO.Items.Count; i++)
			{
			}
		}
		#endregion
		#region Timer Tick Region
		private void Timer_GetData_Tick(object sender, EventArgs e)
		{
			NowTime = DateTime.Now.ToString("[MM dd yyyy hh:mm:ss tt]");
			String datatemp = hook.GetWindowText();
			WriteData(NowTime);
			if(RB_AutoUpdateFast.Checked)
			{
				DoingData();
				DrawChart();
			}
			else if(RB_AutoUpdateSlow.Checked)
			{
				if (fileLine - Log.Count >= 5)
				{
					DoingData();
					DrawChart();
				}
			}
			 
		}
		private void Timer_RegularAlarm_Tick(object sender, EventArgs e)
		{
			Timer_RegularAlarm.Enabled = false;
			hook.PullMySelfToTop(this.Handle);
			MetroFramework.MetroMessageBox.Show(this, ("\n現在時間是 "+DateTime.Now.ToString("tt  hh 點 mm 分")+" 摟，休息一下吧！"), TB_RegularAlarmMsg.Text,MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		#endregion
		#region InterFace Setting
		//Regular Alarm Setting
		private void CB_RegularAlarm_CheckedChanged(object sender, EventArgs e)
		{
			//When Checked, TB will be enabled
			TB_RegularAlarm.Enabled = CB_RegularAlarm.Checked;
			TB_RegularAlarmMsg.Enabled = CB_RegularAlarm.Checked;
			if(CB_RegularAlarm.Checked)
			{
				Timer_RegularAlarm.Enabled = true;
			}
		}
		private void TB_RegularAlarm_TextChanged(object sender, EventArgs e)
		{
			int Interval;
			try
			{
				Interval = int.Parse(TB_RegularAlarm.Text);
				Timer_RegularAlarm.Interval = Interval * 1000 * 60;
			}
			catch(FormatException)
			{
				TB_RegularAlarm.Text = "30";
				MetroFramework.MetroMessageBox.Show(this, "\n格內僅能輸入整數\n若是太常遇到這個問題，請洽開發人員，謝謝", "輸入格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(OverflowException)
			{
				TB_RegularAlarm.Text = "30";
				MetroFramework.MetroMessageBox.Show(this, "\n你的電腦會很累的，讓它休息一下吧！\n若是太常遇到這個問題，請洽開發人員，謝謝", "輸入數字太大", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		//Clean Log Setting
		private void CB_CleanLog_CheckedChanged(object sender, EventArgs e)
		{
			TB_CleanLog.Enabled = CB_CleanLog.Checked;
		}
		//If Textbox Change, Change Validable
		private void TB_CleanLog_TextChanged(object sender, EventArgs e)
		{
			int Interval;
			try
			{
				Interval = int.Parse(TB_CleanLog.Text);
			}
			catch (FormatException)
			{
				TB_CleanLog.Text = "7";
				MetroFramework.MetroMessageBox.Show(this, "\n格內僅能輸入整數\n若是太常遇到這個問題，請洽開發人員，謝謝", "輸入格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (OverflowException)
			{
				TB_CleanLog.Text = "7";
				MetroFramework.MetroMessageBox.Show(this, "\n這樣子你的紀錄檔會超肥超大的哦！\n若是太常遇到這個問題，請洽開發人員，謝謝", "輸入數字太大", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		#endregion
		#region Open Form Loading setting and Close Form save setting And Clean Log
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettingConfig();
			if(CB_CleanLog.Checked)
				CleanLogData(int.Parse(TB_CleanLog.Text));
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			bool OpenSuccess = false;
			OpenSuccess = OpenSettingConfig();
			if(Btn_LogLoc.Text != String.Empty)
				path = Btn_LogLoc.Text;
			if(OpenSuccess)
			{
				MTC.SelectedIndex = 0;
				if(File.Exists(path))
				{
					DoingData();
					DrawChart();
				}
			}
		}
		private void SaveSettingConfig()
		{
			#region Parameter Detail
			/**	LogLocation - 記錄檔位置
			 *	RecordSpeed - 紀錄速度間隔 (20 sec ~ 120 sec)
			 *  RegularEnable - 啟用定時鬧鐘
			 *  RegularAlarmTime - 定時鬧鐘間隔
			 *  RegularAlarmMsg - 定時鬧鐘提醒訊息
			 *  CleanLogEnable - 定時清除記錄檔
			 *  CleanLogTime - 保留幾天內的記錄檔
			 *  AutoUpdateSpeed - 自動更新頻率
			 * **/
			#endregion
			#region Setting data to JSON
			SettingData data = new SettingData();
			data.LogLocation = Btn_LogLoc.Text;
			data.RecordSpeed = metroTrackBar_Speed.Value;
			data.RegularEnable = CB_RegularAlarm.Checked;
			data.RegularAlarmTime = int.Parse(TB_RegularAlarm.Text);
			data.RegularAlarmMsg = TB_RegularAlarmMsg.Text;
			data.CleanLogEnable = CB_CleanLog.Checked;
			data.CleanLogTime = int.Parse(TB_CleanLog.Text);
			if (RB_AutoUpdateFast.Checked)
				data.AutoUpdateSpeed = 1;
			else
				data.AutoUpdateSpeed = 5;
			#endregion
			String SettingData = JsonConvert.SerializeObject(data);
			String StrToHash = SettingData + "aweimeow",hashResult;
			using(MD5 md5Hash = MD5.Create())
			{
				hashResult = GetMd5Hash(md5Hash, StrToHash);
			}
			String WriteInData = SettingData + "@" + hashResult;
			String path = System.Windows.Forms.Application.StartupPath;
			path = path + "\\Setting.config";
			StreamWriter sw = new StreamWriter(path, false);
			sw.Write(WriteInData);
			sw.Close();
		}
		private bool OpenSettingConfig()
		{
			String path = System.Windows.Forms.Application.StartupPath;
			path = path + "\\Setting.config";
			String[] ReadOutData = new String[2];
			if(File.Exists(path))
			{
				StreamReader sr = new StreamReader(path);
				try
				{
					ReadOutData = sr.ReadLine().Split('@');
				}
				catch(Exception)
				{
					MetroFramework.MetroMessageBox.Show(this, "\n應該是您的設定檔被修改過，將會自動刪除無效設定檔\n若是太常遇到這個問題，請洽開發人員，謝謝", "設定檔無效", MessageBoxButtons.OK, MessageBoxIcon.Information);
					File.Delete(path);
				}
				sr.Close();
				using (MD5 md5Hash = MD5.Create())
				{
					if (VerifyMd5Hash(md5Hash, ReadOutData[0] + "aweimeow", ReadOutData[1]))
					{
						SettingData data = JsonConvert.DeserializeObject<SettingData>(ReadOutData[0]);
						Btn_LogLoc.Text = data.LogLocation;
						metroTrackBar_Speed.Value = data.RecordSpeed;
						CB_RegularAlarm.Checked = data.RegularEnable;
						TB_RegularAlarm.Text = data.RegularAlarmTime.ToString();
						TB_RegularAlarmMsg.Text = data.RegularAlarmMsg;
						CB_CleanLog.Checked = data.CleanLogEnable;
						TB_CleanLog.Text = data.CleanLogTime.ToString();
						lbl_DataSec.Text = data.RecordSpeed.ToString() + " 秒";
						if (data.AutoUpdateSpeed == 1)
							RB_AutoUpdateFast.Checked = true;
						else
							RB_AutoUpdateSlow.Checked = true;
						return true;
					}
					else
					{
						MetroFramework.MetroMessageBox.Show(this, "\n應該是您的設定檔被修改過，無法經過驗證，將會自動刪除無效設定檔\n若是太常遇到這個問題，請洽開發人員，謝謝", "設定檔無效", MessageBoxButtons.OK, MessageBoxIcon.Information);
						File.Delete(path);
					}
				}			
			}
			else
			{
				MTC.SelectedIndex = 2;
				MetroFramework.MetroMessageBox.Show(this, "\n這應該是您第一次使用本程式吧，歡迎您\n請先進行設定，設定完後便可以開始，\n在程式正常關閉後會自動儲存設定", "歡迎使用 Time Helper", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			return false;
		}
		#endregion
		#region Core Code
		//Write Data into Log
		private void WriteData(String Time)
		{
			StreamWriter sw;			//StreamWriter, without new so much time
			WriteInData = String.Empty;
			String datatemp = hook.GetWindowText();
			int dashcount = Regex.Matches(datatemp, "-").Count;
			if (dashcount > 0)
			{
				string[] para = datatemp.Split('-');
				//Change Ex. A-B-C >> C-B-A
				for (int i = para.Count() - 1; i >= 0; i--)
				{
					//Clean the parameter
					if (para[i].Length > 0)
					{
						if (para[i][0] == ' ')
							para[i] = para[i].Substring(1, para[i].Length - 1);
						if (para[i][para[i].Length - 1] == ' ')
							para[i] = para[i].Substring(0, para[i].Length - 1);
					}
					if (i == para.Count() - 1)
						WriteInData = para[i];
					else
						WriteInData += "-" + para[i];
				}
			}
			else
			{
				WriteInData = datatemp;
			}
			WriteInData = Time + WriteInData;
			//假如檔案的行數還沒設定，也就代表是新開的log檔，則需要重置fileLine
			if (fileLine == -1)
				fileLine = 0;
			fileLine++;
			sw = new StreamWriter(path, true);
			sw.WriteLine(WriteInData);
			sw.Close();
		}
		//Clean Log make log is not too fat
		private void CleanLogData(int day)
		{
			String tempPath = "C:\\Windows\\Temp\\TimeHelperTemp-"+new Random().Next(int.MinValue, int.MaxValue)+".tmp";
			try
			{
				using (var input = File.OpenText(path))
				{
					using (var output = new StreamWriter(tempPath))
					{
						string Line;
						string Time;
						DateTime RecordTime;
						while ((Line = input.ReadLine()) != null)
						{
							Time = Line.Substring(1, Line.IndexOf(']') - 1);
							RecordTime = Convert.ToDateTime(Time);
							TimeSpan ts = DateTime.Now - RecordTime;
							if (ts.Days < day)
							{
								output.WriteLine(Line);
							}
						}
					}
				}
				File.Delete(path);
				File.Move(tempPath, path);
			}
			catch(Exception)
			{
				///Can not find File
			}
		}
		//Convert log data to Serialize Data
		private void DoingData()
		{
			int NowReadLineIndex = -1;
			using (StreamReader sr = new StreamReader(path))
			{
				String OneLineData = String.Empty;
				String DateStamp = String.Empty;
				String DataAPP = String.Empty;
				String DataOther = String.Empty;
				while ((OneLineData = sr.ReadLine()) != null)
				{
					//Initialization
					//This Can Make the code beauty, it will save time
					if(NowReadLineIndex == LogDataIndex)
					{
						LogData log = new LogData();
						DateStamp = String.Empty; DataAPP = String.Empty; DataOther = String.Empty;
						DateStamp = OneLineData.Substring(1, OneLineData.IndexOf(']') - 1);
						DataAPP = OneLineData.Substring(OneLineData.IndexOf(']') + 1);
						if (DataAPP.Length > 0)
						{
							if(DataAPP.IndexOf('-')>-1)
							{
								DataOther = DataAPP.Substring(DataAPP.IndexOf('-') + 1);
								DataAPP = DataAPP.Substring(0, DataAPP.IndexOf('-'));
							}
						}
						log.date = Convert.ToDateTime(DateStamp);
						log.APP = DataAPP;
						log.OtherInformation = DataOther;
						Log.Add(log);
						LogDataIndex++;
					}
					NowReadLineIndex++;
				}
			}
		}
		//Draw Chart
		private void DrawChart()
		{
			Series Series_Data = new Series();
			Legend legend = new Legend();
			int StaticTotalCount = 0;
			for(int i = 0; i<StaticsData.Count; i++)
				StaticTotalCount += StaticsData[i].Count;
			for (int i = (Chart_Main.Series.Count == 0) ? 0 : StaticTotalCount; i < Log.Count; i++)
			{
				int index = CheckStaticAvailable(Log[i].APP);
				if (index > -1)
					StaticsData[index].Count++;
				else
				{
					ChartData CD = new ChartData();
					CD.AppName = Log[i].APP;
					CD.Count = 1;
					StaticsData.Add(CD);
				}
			}
			String[] AppName = new String[StaticsData.Count];
			int[] AppUsage = new int[StaticsData.Count];
			for (int i = 0; i < StaticsData.Count; i++)
			{
				if (StaticsData[i].AppName == "")
				{
					AppName[i] = "未知";
					AppUsage[i] = StaticsData[i].Count;
				}
				else
				{
					AppName[i] = StaticsData[i].AppName;
					AppUsage[i] = StaticsData[i].Count;
				}
			}
			Series_Data.ChartType = SeriesChartType.Pie;
			Series_Data.IsValueShownAsLabel = true;
			Series_Data.Points.DataBindXY(AppName, AppUsage);
			Series_Data.Font = new Font("Comic Sans MS", 14, FontStyle.Regular);
			legend.BackColor = Color.FromArgb(235, 235, 235);
			legend.BackHatchStyle = ChartHatchStyle.DarkDownwardDiagonal;
			legend.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
			Chart_Main.Series.Clear();
			Chart_Main.Legends.Clear();
			Chart_Main.Series.Add(Series_Data);
			Chart_Main.Legends.Add(legend);
		}
		//Check if StaticChartData have the Name, if yes then return index value
		private int CheckStaticAvailable(String AppName)
		{
			int value = -1;
			for (int i = 0; i < StaticsData.Count; i++)
				if (StaticsData[i].AppName == AppName)
					value = i;
			return value;
		}
		//Get the Count of the log file already exist
		private int GetTotalLineCount(String path)
		{
			int count = 0;
			using(StreamReader sr = new StreamReader(path))
			{
				while (sr.ReadLine() != null)
					count++;
			}
			return count;
		}
		#endregion
		#region MD5 encrypt and verify
		//Source : https://msdn.microsoft.com/zh-tw/library/system.security.cryptography.md5%28v=vs.110%29.aspx
		static string GetMd5Hash(MD5 md5Hash, string input)
		{

			// Convert the input string to a byte array and compute the hash.
			byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

			// Create a new Stringbuilder to collect the bytes
			// and create a string.
			StringBuilder sBuilder = new StringBuilder();

			// Loop through each byte of the hashed data 
			// and format each one as a hexadecimal string.
			for (int i = 0; i < data.Length; i++)
			{
				sBuilder.Append(data[i].ToString("x2"));
			}

			// Return the hexadecimal string.
			return sBuilder.ToString();
		}
		static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
		{
			// Hash the input.
			string hashOfInput = GetMd5Hash(md5Hash, input);

			// Create a StringComparer an compare the hashes.
			StringComparer comparer = StringComparer.OrdinalIgnoreCase;

			if (0 == comparer.Compare(hashOfInput, hash))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion



	}
	#region WinAPI - Get Top Windows Name
	public class HookFunction
	{
		[DllImport("user32.dll")]
		static extern IntPtr GetForegroundWindow();
		[DllImport("user32.dll")]
		static extern int GetWindowText(IntPtr hWnd, StringBuilder lpText, int nCount);
		[DllImport("user32.dll")]
		static extern bool SetForegroundWindow(IntPtr hWnd);

		//Return the top window's hWnd
		private IntPtr GetTopWindow()
		{
			IntPtr hwnd = GetForegroundWindow();
			return hwnd;
		}
		//Return the top window's title
		public String GetWindowText()
		{
			IntPtr hwnd = GetTopWindow();
			var str = new StringBuilder(256);
			GetWindowText(hwnd, str, str.Capacity);
			return str.ToString();
		}

		public void PullMySelfToTop(IntPtr hwnd)
		{
			SetForegroundWindow(hwnd);
		}
	}
	#endregion
}
