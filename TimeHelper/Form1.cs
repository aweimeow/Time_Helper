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

namespace TimeHelper
{
	public partial class Form1 : MetroForm
	{
		public class SettingData
		{
			/**	LocLocation - 記錄檔位置
			 *	RecordSpeed - 紀錄速度間隔 (20 sec ~ 120 sec)
			 *  RegularEnable - 啟用定時鬧鐘
			 *  RegularAlarmTime - 定時鬧鐘間隔
			 *  RegularAlarmMsg - 定時鬧鐘提醒訊息
			 *  CleanLogEnable - 定時清除記錄檔
			 *  CleanLogTime - 保留幾天內的記錄檔
			 * **/
			public String LogLocation { get; set; }
			public int RecordSpeed { get; set; }
			public bool RegularEnable { get; set; }
			public int RegularAlarmTime { get; set; }
			public String RegularAlarmMsg { get; set; }
			public bool CleanLogEnable { get; set; }
			public int CleanLogTime { get; set; }
		}

		#region Global Variable
		HookFunction hook = new HookFunction();
		String NowTime = "";		//現在時間
		String path = "";			//Log檔路徑
		String WriteInData = "";	//要寫入的資料
		StreamWriter sw;			//StreamWriter, without new so much time
		#endregion

		public Form1()
		{
			InitializeComponent();
		}

		#region 選擇記錄檔路徑
		private void TB_LogLoc_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			FolderBrowserDialog path = new FolderBrowserDialog();
			path.ShowDialog();
			if (path.SelectedPath != String.Empty)
				TB_LogLoc.Text = path.SelectedPath + "\\TimeHelper.log";
		}
		#endregion

		#region 紀錄間隔時間
		private void metroTrackBar_Speed_Scroll(object sender, ScrollEventArgs e)
		{
			lbl_DataSec.Text = metroTrackBar_Speed.Value + " 秒";
		}
		#endregion
		

		private void Btn_Start_Click(object sender, EventArgs e)
		{
			//path = TB_LogLoc.Text;
			//Timer_GetData.Enabled = true;
			SaveSettingConfig();
		}

		private void Timer_GetData_Tick(object sender, EventArgs e)
		{
			NowTime = DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]");
			String datatemp = hook.GetWindowText();
			WriteData(NowTime);
		}

		private void WriteData(String Time)
		{
			String datatemp = hook.GetWindowText();
			int dashcount = Regex.Matches(datatemp, "-").Count;
			string[] para = datatemp.Split('-');
			//Change Ex. A-B-C >> C-B-A
			for (int i = para.Count() - 1; i >= 0; i-- )
			{
				//Clean the parameter
				if(para[i][0] == ' ')
					para[i] = para[i].Substring(1, para[i].Length - 1);
				if (para[i][para[i].Length - 1] == ' ')
					para[i] = para[i].Substring(0, para[i].Length - 1);
				if(i == para.Count() - 1)
					WriteInData = para[i];
				else
					WriteInData += "-" + para[i];
			}
			WriteInData = Time + WriteInData;
			sw = new StreamWriter(path, true, Encoding.Unicode);
			sw.WriteLine(WriteInData);
			sw.Close();
		}

		private void Btn_Stop_Click(object sender, EventArgs e)
		{
			Timer_GetData.Enabled = false;
		}

		#region InterFace Setting
		//Record Speed
		private void metroTrackBar_Speed_ValueChanged(object sender, EventArgs e)
		{
			Timer_GetData.Interval = metroTrackBar_Speed.Value * 1000;
		}
		//Regular Alarm Setting
		private void CB_RegularAlarm_CheckedChanged(object sender, EventArgs e)
		{
			//When Checked, TB will be enabled
			TB_RegularAlarm.Enabled = CB_RegularAlarm.Checked;
			TB_RegularAlarmMsg.Enabled = CB_RegularAlarm.Checked;
		}
		private void TB_RegularAlarm_TextChanged(object sender, EventArgs e)
		{
			int test;
			try
			{
				test = int.Parse(TB_RegularAlarm.Text);
			}
			catch(FormatException)
			{
				TB_RegularAlarm.Text = "30";
				MetroFramework.MetroMessageBox.Show(this, "\n格內僅能輸入整數\n若是太常遇到這個問題，請洽開發人員，謝謝", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(OverflowException)
			{
				TB_RegularAlarm.Text = "30";
				MetroFramework.MetroMessageBox.Show(this, "\n你的電腦都不用關機的嗎？\n若是太常遇到這個問題，請洽開發人員，謝謝", "數字太大", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		//Clean Log Setting
		private void CB_CleanLog_CheckedChanged(object sender, EventArgs e)
		{
			TB_CleanLog.Enabled = CB_CleanLog.Checked;
		}
		#endregion

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
			 * **/
			#endregion
			#region Setting data to JSON
			SettingData data = new SettingData();
			data.LogLocation = TB_LogLoc.Text;
			data.RecordSpeed = metroTrackBar_Speed.Value;
			data.RegularEnable = CB_RegularAlarm.Checked;
			data.RegularAlarmTime = int.Parse(TB_RegularAlarm.Text);
			data.RegularAlarmMsg = TB_RegularAlarmMsg.Text;
			data.CleanLogEnable = CB_CleanLog.Checked;
			data.CleanLogTime = int.Parse(TB_CleanLog.Text);
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
		private void OpenSettingConfig()
		{
			String path = System.Windows.Forms.Application.StartupPath;
			path = path + "\\Setting.config";
			String[] ReadOutData;
			if(File.Exists(path))
			{
				StreamReader sr = new StreamReader(path);
				ReadOutData = sr.ReadLine().Split('@');
				sr.Close();
			}
			using(MD5 md5Hash = MD5.Create())
			{
				if(VerifyMd5Hash(md5Hash, ReadOutData[0]+"aweimeow", ReadOutData[1]))
				{

				}
			}
		}

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

	public class HookFunction
	{
		[DllImport("user32.dll")]
		static extern IntPtr GetForegroundWindow();
		[DllImport("user32.dll")]
		static extern int GetWindowText(IntPtr hWnd, StringBuilder lpText, int nCount);

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
	}
}
