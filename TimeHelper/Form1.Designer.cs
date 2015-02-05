namespace TimeHelper
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
		/// 修改這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Timer_GetData = new System.Windows.Forms.Timer(this.components);
			this.MTC = new MetroFramework.Controls.MetroTabControl();
			this.TabPage_Main = new System.Windows.Forms.TabPage();
			this.TabPage_Setting = new System.Windows.Forms.TabPage();
			this.TB_RegularAlarmMsg = new System.Windows.Forms.TextBox();
			this.lblc_RegularAlarmCustomMsg = new System.Windows.Forms.Label();
			this.lblc_RegularAlarmL = new System.Windows.Forms.Label();
			this.TB_RegularAlarm = new System.Windows.Forms.TextBox();
			this.lblc_RegularAlarmF = new System.Windows.Forms.Label();
			this.CB_RegularAlarm = new System.Windows.Forms.CheckBox();
			this.lbl_DataSec = new System.Windows.Forms.Label();
			this.metroTrackBar_Speed = new MetroFramework.Controls.MetroTrackBar();
			this.lblc_DataSec = new System.Windows.Forms.Label();
			this.TB_LogLoc = new System.Windows.Forms.TextBox();
			this.lblc_logloc = new System.Windows.Forms.Label();
			this.Btn_Start = new System.Windows.Forms.Button();
			this.Btn_Stop = new System.Windows.Forms.Button();
			this.Timer_RegularAlarm = new System.Windows.Forms.Timer(this.components);
			this.CB_CleanLog = new System.Windows.Forms.CheckBox();
			this.TB_CleanLog = new System.Windows.Forms.TextBox();
			this.lblc_CleanLogL = new System.Windows.Forms.Label();
			this.lblc_CleanLogF = new System.Windows.Forms.Label();
			this.MTC.SuspendLayout();
			this.TabPage_Setting.SuspendLayout();
			this.SuspendLayout();
			// 
			// Timer_GetData
			// 
			this.Timer_GetData.Interval = 2000;
			this.Timer_GetData.Tick += new System.EventHandler(this.Timer_GetData_Tick);
			// 
			// MTC
			// 
			this.MTC.Controls.Add(this.TabPage_Main);
			this.MTC.Controls.Add(this.TabPage_Setting);
			this.MTC.FontSize = MetroFramework.MetroTabControlSize.Tall;
			this.MTC.Location = new System.Drawing.Point(16, 58);
			this.MTC.Name = "MTC";
			this.MTC.SelectedIndex = 1;
			this.MTC.Size = new System.Drawing.Size(607, 596);
			this.MTC.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.MTC.TabIndex = 0;
			this.MTC.Theme = MetroFramework.MetroThemeStyle.Light;
			this.MTC.UseSelectable = true;
			// 
			// TabPage_Main
			// 
			this.TabPage_Main.BackColor = System.Drawing.Color.White;
			this.TabPage_Main.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.TabPage_Main.Location = new System.Drawing.Point(4, 44);
			this.TabPage_Main.Name = "TabPage_Main";
			this.TabPage_Main.Size = new System.Drawing.Size(599, 548);
			this.TabPage_Main.TabIndex = 0;
			this.TabPage_Main.Text = "主視窗";
			// 
			// TabPage_Setting
			// 
			this.TabPage_Setting.BackColor = System.Drawing.Color.White;
			this.TabPage_Setting.Controls.Add(this.TB_CleanLog);
			this.TabPage_Setting.Controls.Add(this.lblc_CleanLogL);
			this.TabPage_Setting.Controls.Add(this.lblc_CleanLogF);
			this.TabPage_Setting.Controls.Add(this.CB_CleanLog);
			this.TabPage_Setting.Controls.Add(this.TB_RegularAlarmMsg);
			this.TabPage_Setting.Controls.Add(this.lblc_RegularAlarmCustomMsg);
			this.TabPage_Setting.Controls.Add(this.lblc_RegularAlarmL);
			this.TabPage_Setting.Controls.Add(this.TB_RegularAlarm);
			this.TabPage_Setting.Controls.Add(this.lblc_RegularAlarmF);
			this.TabPage_Setting.Controls.Add(this.CB_RegularAlarm);
			this.TabPage_Setting.Controls.Add(this.lbl_DataSec);
			this.TabPage_Setting.Controls.Add(this.metroTrackBar_Speed);
			this.TabPage_Setting.Controls.Add(this.lblc_DataSec);
			this.TabPage_Setting.Controls.Add(this.TB_LogLoc);
			this.TabPage_Setting.Controls.Add(this.lblc_logloc);
			this.TabPage_Setting.Location = new System.Drawing.Point(4, 44);
			this.TabPage_Setting.Name = "TabPage_Setting";
			this.TabPage_Setting.Size = new System.Drawing.Size(599, 548);
			this.TabPage_Setting.TabIndex = 1;
			this.TabPage_Setting.Text = "設定";
			// 
			// TB_RegularAlarmMsg
			// 
			this.TB_RegularAlarmMsg.Enabled = false;
			this.TB_RegularAlarmMsg.Location = new System.Drawing.Point(200, 215);
			this.TB_RegularAlarmMsg.Name = "TB_RegularAlarmMsg";
			this.TB_RegularAlarmMsg.Size = new System.Drawing.Size(374, 39);
			this.TB_RegularAlarmMsg.TabIndex = 15;
			this.TB_RegularAlarmMsg.Text = "該起身走動走動摟！";
			// 
			// lblc_RegularAlarmCustomMsg
			// 
			this.lblc_RegularAlarmCustomMsg.AutoSize = true;
			this.lblc_RegularAlarmCustomMsg.Location = new System.Drawing.Point(20, 220);
			this.lblc_RegularAlarmCustomMsg.Name = "lblc_RegularAlarmCustomMsg";
			this.lblc_RegularAlarmCustomMsg.Size = new System.Drawing.Size(181, 30);
			this.lblc_RegularAlarmCustomMsg.TabIndex = 14;
			this.lblc_RegularAlarmCustomMsg.Text = "自訂提醒訊息：";
			// 
			// lblc_RegularAlarmL
			// 
			this.lblc_RegularAlarmL.AutoSize = true;
			this.lblc_RegularAlarmL.Location = new System.Drawing.Point(205, 170);
			this.lblc_RegularAlarmL.Name = "lblc_RegularAlarmL";
			this.lblc_RegularAlarmL.Size = new System.Drawing.Size(157, 30);
			this.lblc_RegularAlarmL.TabIndex = 13;
			this.lblc_RegularAlarmL.Text = "分鐘　提醒我";
			// 
			// TB_RegularAlarm
			// 
			this.TB_RegularAlarm.Enabled = false;
			this.TB_RegularAlarm.Location = new System.Drawing.Point(90, 165);
			this.TB_RegularAlarm.Name = "TB_RegularAlarm";
			this.TB_RegularAlarm.Size = new System.Drawing.Size(100, 39);
			this.TB_RegularAlarm.TabIndex = 12;
			this.TB_RegularAlarm.Text = "60";
			this.TB_RegularAlarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TB_RegularAlarm.TextChanged += new System.EventHandler(this.TB_RegularAlarm_TextChanged);
			// 
			// lblc_RegularAlarmF
			// 
			this.lblc_RegularAlarmF.AutoSize = true;
			this.lblc_RegularAlarmF.Location = new System.Drawing.Point(20, 170);
			this.lblc_RegularAlarmF.Name = "lblc_RegularAlarmF";
			this.lblc_RegularAlarmF.Size = new System.Drawing.Size(61, 30);
			this.lblc_RegularAlarmF.TabIndex = 11;
			this.lblc_RegularAlarmF.Text = "每過";
			// 
			// CB_RegularAlarm
			// 
			this.CB_RegularAlarm.AutoSize = true;
			this.CB_RegularAlarm.Location = new System.Drawing.Point(20, 120);
			this.CB_RegularAlarm.Name = "CB_RegularAlarm";
			this.CB_RegularAlarm.Size = new System.Drawing.Size(183, 34);
			this.CB_RegularAlarm.TabIndex = 10;
			this.CB_RegularAlarm.Text = "啟用定時提醒";
			this.CB_RegularAlarm.UseVisualStyleBackColor = true;
			this.CB_RegularAlarm.CheckedChanged += new System.EventHandler(this.CB_RegularAlarm_CheckedChanged);
			// 
			// lbl_DataSec
			// 
			this.lbl_DataSec.AutoSize = true;
			this.lbl_DataSec.Location = new System.Drawing.Point(500, 70);
			this.lbl_DataSec.Name = "lbl_DataSec";
			this.lbl_DataSec.Size = new System.Drawing.Size(71, 30);
			this.lbl_DataSec.TabIndex = 9;
			this.lbl_DataSec.Text = "60 秒";
			// 
			// metroTrackBar_Speed
			// 
			this.metroTrackBar_Speed.BackColor = System.Drawing.Color.Transparent;
			this.metroTrackBar_Speed.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.metroTrackBar_Speed.Location = new System.Drawing.Point(165, 65);
			this.metroTrackBar_Speed.Maximum = 120;
			this.metroTrackBar_Speed.Minimum = 20;
			this.metroTrackBar_Speed.Name = "metroTrackBar_Speed";
			this.metroTrackBar_Speed.Size = new System.Drawing.Size(316, 40);
			this.metroTrackBar_Speed.TabIndex = 8;
			this.metroTrackBar_Speed.Text = "metroTrackBar1";
			this.metroTrackBar_Speed.Value = 60;
			this.metroTrackBar_Speed.ValueChanged += new System.EventHandler(this.metroTrackBar_Speed_ValueChanged);
			this.metroTrackBar_Speed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar_Speed_Scroll);
			// 
			// lblc_DataSec
			// 
			this.lblc_DataSec.AutoSize = true;
			this.lblc_DataSec.Location = new System.Drawing.Point(20, 70);
			this.lblc_DataSec.Name = "lblc_DataSec";
			this.lblc_DataSec.Size = new System.Drawing.Size(127, 30);
			this.lblc_DataSec.TabIndex = 7;
			this.lblc_DataSec.Text = "紀錄速度 : ";
			// 
			// TB_LogLoc
			// 
			this.TB_LogLoc.Location = new System.Drawing.Point(160, 10);
			this.TB_LogLoc.Name = "TB_LogLoc";
			this.TB_LogLoc.Size = new System.Drawing.Size(414, 39);
			this.TB_LogLoc.TabIndex = 6;
			this.TB_LogLoc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TB_LogLoc_MouseDoubleClick);
			// 
			// lblc_logloc
			// 
			this.lblc_logloc.AutoSize = true;
			this.lblc_logloc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblc_logloc.Location = new System.Drawing.Point(10, 15);
			this.lblc_logloc.Name = "lblc_logloc";
			this.lblc_logloc.Size = new System.Drawing.Size(151, 30);
			this.lblc_logloc.TabIndex = 5;
			this.lblc_logloc.Text = "記錄檔路徑 : ";
			// 
			// Btn_Start
			// 
			this.Btn_Start.BackColor = System.Drawing.Color.White;
			this.Btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Start.Location = new System.Drawing.Point(650, 28);
			this.Btn_Start.Name = "Btn_Start";
			this.Btn_Start.Size = new System.Drawing.Size(170, 78);
			this.Btn_Start.TabIndex = 1;
			this.Btn_Start.Text = "開始記錄";
			this.Btn_Start.UseVisualStyleBackColor = false;
			this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
			// 
			// Btn_Stop
			// 
			this.Btn_Stop.BackColor = System.Drawing.Color.White;
			this.Btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Stop.Location = new System.Drawing.Point(650, 112);
			this.Btn_Stop.Name = "Btn_Stop";
			this.Btn_Stop.Size = new System.Drawing.Size(170, 78);
			this.Btn_Stop.TabIndex = 2;
			this.Btn_Stop.Text = "停止記錄";
			this.Btn_Stop.UseVisualStyleBackColor = false;
			this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
			// 
			// Timer_RegularAlarm
			// 
			this.Timer_RegularAlarm.Interval = 3600000;
			// 
			// CB_CleanLog
			// 
			this.CB_CleanLog.AutoSize = true;
			this.CB_CleanLog.Checked = true;
			this.CB_CleanLog.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CB_CleanLog.Location = new System.Drawing.Point(20, 270);
			this.CB_CleanLog.Name = "CB_CleanLog";
			this.CB_CleanLog.Size = new System.Drawing.Size(207, 34);
			this.CB_CleanLog.TabIndex = 16;
			this.CB_CleanLog.Text = "定時清除記錄檔";
			this.CB_CleanLog.UseVisualStyleBackColor = true;
			this.CB_CleanLog.CheckedChanged += new System.EventHandler(this.CB_CleanLog_CheckedChanged);
			// 
			// TB_CleanLog
			// 
			this.TB_CleanLog.Location = new System.Drawing.Point(110, 310);
			this.TB_CleanLog.Name = "TB_CleanLog";
			this.TB_CleanLog.Size = new System.Drawing.Size(100, 39);
			this.TB_CleanLog.TabIndex = 19;
			this.TB_CleanLog.Text = "30";
			this.TB_CleanLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblc_CleanLogL
			// 
			this.lblc_CleanLogL.AutoSize = true;
			this.lblc_CleanLogL.Location = new System.Drawing.Point(230, 315);
			this.lblc_CleanLogL.Name = "lblc_CleanLogL";
			this.lblc_CleanLogL.Size = new System.Drawing.Size(133, 30);
			this.lblc_CleanLogL.TabIndex = 18;
			this.lblc_CleanLogL.Text = "天內的紀錄";
			// 
			// lblc_CleanLogF
			// 
			this.lblc_CleanLogF.AutoSize = true;
			this.lblc_CleanLogF.Location = new System.Drawing.Point(20, 315);
			this.lblc_CleanLogF.Name = "lblc_CleanLogF";
			this.lblc_CleanLogF.Size = new System.Drawing.Size(85, 30);
			this.lblc_CleanLogF.TabIndex = 17;
			this.lblc_CleanLogF.Text = "只保留";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(849, 669);
			this.Controls.Add(this.Btn_Stop);
			this.Controls.Add(this.Btn_Start);
			this.Controls.Add(this.MTC);
			this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(31, 100, 31, 33);
			this.Text = "Time Helper";
			this.MTC.ResumeLayout(false);
			this.TabPage_Setting.ResumeLayout(false);
			this.TabPage_Setting.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer Timer_GetData;
		private MetroFramework.Controls.MetroTabControl MTC;
		private System.Windows.Forms.TabPage TabPage_Main;
		private System.Windows.Forms.TabPage TabPage_Setting;
		private System.Windows.Forms.TextBox TB_LogLoc;
		private System.Windows.Forms.Label lblc_logloc;
		private MetroFramework.Controls.MetroTrackBar metroTrackBar_Speed;
		private System.Windows.Forms.Label lblc_DataSec;
		private System.Windows.Forms.Label lbl_DataSec;
		private System.Windows.Forms.Button Btn_Start;
		private System.Windows.Forms.Button Btn_Stop;
		private System.Windows.Forms.Label lblc_RegularAlarmL;
		private System.Windows.Forms.TextBox TB_RegularAlarm;
		private System.Windows.Forms.Label lblc_RegularAlarmF;
		private System.Windows.Forms.CheckBox CB_RegularAlarm;
		private System.Windows.Forms.Timer Timer_RegularAlarm;
		private System.Windows.Forms.TextBox TB_RegularAlarmMsg;
		private System.Windows.Forms.Label lblc_RegularAlarmCustomMsg;
		private System.Windows.Forms.TextBox TB_CleanLog;
		private System.Windows.Forms.Label lblc_CleanLogL;
		private System.Windows.Forms.Label lblc_CleanLogF;
		private System.Windows.Forms.CheckBox CB_CleanLog;
	}
}

