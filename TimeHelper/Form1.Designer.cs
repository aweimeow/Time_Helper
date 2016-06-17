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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			this.Timer_GetData = new System.Windows.Forms.Timer(this.components);
			this.MTC = new MetroFramework.Controls.MetroTabControl();
			this.TabPage_Main = new System.Windows.Forms.TabPage();
			this.Chart_Main = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.TabPage_TODO = new System.Windows.Forms.TabPage();
			this.Btn_addtodo = new System.Windows.Forms.Button();
			this.TB_addtodo = new System.Windows.Forms.TextBox();
			this.lbl_addtodo = new System.Windows.Forms.Label();
			this.CLB_TODO = new System.Windows.Forms.CheckedListBox();
			this.TabPage_Setting = new System.Windows.Forms.TabPage();
			this.CB_AutoRun = new System.Windows.Forms.CheckBox();
			this.GB_AutoUpdate = new System.Windows.Forms.GroupBox();
			this.RB_AutoUpdateSlow = new System.Windows.Forms.RadioButton();
			this.RB_AutoUpdateFast = new System.Windows.Forms.RadioButton();
			this.Btn_LogLoc = new System.Windows.Forms.Button();
			this.TB_CleanLog = new System.Windows.Forms.TextBox();
			this.lblc_CleanLogL = new System.Windows.Forms.Label();
			this.lblc_CleanLogF = new System.Windows.Forms.Label();
			this.CB_CleanLog = new System.Windows.Forms.CheckBox();
			this.TB_RegularAlarmMsg = new System.Windows.Forms.TextBox();
			this.lblc_RegularAlarmCustomMsg = new System.Windows.Forms.Label();
			this.lblc_RegularAlarmL = new System.Windows.Forms.Label();
			this.TB_RegularAlarm = new System.Windows.Forms.TextBox();
			this.lblc_RegularAlarmF = new System.Windows.Forms.Label();
			this.CB_RegularAlarm = new System.Windows.Forms.CheckBox();
			this.lbl_DataSec = new System.Windows.Forms.Label();
			this.metroTrackBar_Speed = new MetroFramework.Controls.MetroTrackBar();
			this.lblc_DataSec = new System.Windows.Forms.Label();
			this.lblc_logloc = new System.Windows.Forms.Label();
			this.Btn_Start = new System.Windows.Forms.Button();
			this.Btn_Stop = new System.Windows.Forms.Button();
			this.Timer_RegularAlarm = new System.Windows.Forms.Timer(this.components);
			this.MTC.SuspendLayout();
			this.TabPage_Main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Chart_Main)).BeginInit();
			this.TabPage_TODO.SuspendLayout();
			this.TabPage_Setting.SuspendLayout();
			this.GB_AutoUpdate.SuspendLayout();
			this.SuspendLayout();
			// 
			// Timer_GetData
			// 
			this.Timer_GetData.Interval = 1000;
			this.Timer_GetData.Tick += new System.EventHandler(this.Timer_GetData_Tick);
			// 
			// MTC
			// 
			this.MTC.AccessibleDescription = "";
			this.MTC.Controls.Add(this.TabPage_Main);
			this.MTC.Controls.Add(this.TabPage_TODO);
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
			this.MTC.SelectedIndexChanged += new System.EventHandler(this.MTC_SelectedIndexChanged);
			// 
			// TabPage_Main
			// 
			this.TabPage_Main.BackColor = System.Drawing.Color.White;
			this.TabPage_Main.Controls.Add(this.Chart_Main);
			this.TabPage_Main.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.TabPage_Main.Location = new System.Drawing.Point(4, 44);
			this.TabPage_Main.Name = "TabPage_Main";
			this.TabPage_Main.Size = new System.Drawing.Size(599, 548);
			this.TabPage_Main.TabIndex = 0;
			this.TabPage_Main.Text = "主視窗";
			// 
			// Chart_Main
			// 
			chartArea1.Name = "ChartArea1";
			this.Chart_Main.ChartAreas.Add(chartArea1);
			this.Chart_Main.Location = new System.Drawing.Point(10, 10);
			this.Chart_Main.Name = "Chart_Main";
			this.Chart_Main.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			this.Chart_Main.Size = new System.Drawing.Size(573, 525);
			this.Chart_Main.TabIndex = 4;
			// 
			// TabPage_TODO
			// 
			this.TabPage_TODO.BackColor = System.Drawing.Color.White;
			this.TabPage_TODO.Controls.Add(this.Btn_addtodo);
			this.TabPage_TODO.Controls.Add(this.TB_addtodo);
			this.TabPage_TODO.Controls.Add(this.lbl_addtodo);
			this.TabPage_TODO.Controls.Add(this.CLB_TODO);
			this.TabPage_TODO.Location = new System.Drawing.Point(4, 44);
			this.TabPage_TODO.Name = "TabPage_TODO";
			this.TabPage_TODO.Size = new System.Drawing.Size(599, 548);
			this.TabPage_TODO.TabIndex = 2;
			this.TabPage_TODO.Text = "待辦事項";
			// 
			// Btn_addtodo
			// 
			this.Btn_addtodo.Location = new System.Drawing.Point(484, 8);
			this.Btn_addtodo.Name = "Btn_addtodo";
			this.Btn_addtodo.Size = new System.Drawing.Size(100, 38);
			this.Btn_addtodo.TabIndex = 8;
			this.Btn_addtodo.Text = "add";
			this.Btn_addtodo.UseVisualStyleBackColor = true;
			this.Btn_addtodo.Click += new System.EventHandler(this.Btn_addtodo_Click);
			// 
			// TB_addtodo
			// 
			this.TB_addtodo.Location = new System.Drawing.Point(180, 7);
			this.TB_addtodo.Name = "TB_addtodo";
			this.TB_addtodo.Size = new System.Drawing.Size(295, 39);
			this.TB_addtodo.TabIndex = 7;
			// 
			// lbl_addtodo
			// 
			this.lbl_addtodo.AutoSize = true;
			this.lbl_addtodo.Location = new System.Drawing.Point(22, 12);
			this.lbl_addtodo.Name = "lbl_addtodo";
			this.lbl_addtodo.Size = new System.Drawing.Size(154, 30);
			this.lbl_addtodo.TabIndex = 6;
			this.lbl_addtodo.Text = "New TODO: ";
			// 
			// CLB_TODO
			// 
			this.CLB_TODO.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.CLB_TODO.FormattingEnabled = true;
			this.CLB_TODO.Location = new System.Drawing.Point(17, 60);
			this.CLB_TODO.Name = "CLB_TODO";
			this.CLB_TODO.Size = new System.Drawing.Size(567, 404);
			this.CLB_TODO.TabIndex = 4;
			this.CLB_TODO.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CLB_TODO_MouseUp);
			// 
			// TabPage_Setting
			// 
			this.TabPage_Setting.BackColor = System.Drawing.Color.White;
			this.TabPage_Setting.Controls.Add(this.CB_AutoRun);
			this.TabPage_Setting.Controls.Add(this.GB_AutoUpdate);
			this.TabPage_Setting.Controls.Add(this.Btn_LogLoc);
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
			this.TabPage_Setting.Controls.Add(this.lblc_logloc);
			this.TabPage_Setting.Location = new System.Drawing.Point(4, 44);
			this.TabPage_Setting.Name = "TabPage_Setting";
			this.TabPage_Setting.Size = new System.Drawing.Size(599, 548);
			this.TabPage_Setting.TabIndex = 1;
			this.TabPage_Setting.Text = "設定";
			// 
			// CB_AutoRun
			// 
			this.CB_AutoRun.AutoSize = true;
			this.CB_AutoRun.Location = new System.Drawing.Point(365, 311);
			this.CB_AutoRun.Name = "CB_AutoRun";
			this.CB_AutoRun.Size = new System.Drawing.Size(303, 34);
			this.CB_AutoRun.TabIndex = 22;
			this.CB_AutoRun.Text = "啟用開機時自動執行程式";
			this.CB_AutoRun.UseVisualStyleBackColor = true;
			this.CB_AutoRun.CheckedChanged += new System.EventHandler(this.CB_Regist_CheckedChanged);
			// 
			// GB_AutoUpdate
			// 
			this.GB_AutoUpdate.Controls.Add(this.RB_AutoUpdateSlow);
			this.GB_AutoUpdate.Controls.Add(this.RB_AutoUpdateFast);
			this.GB_AutoUpdate.Location = new System.Drawing.Point(10, 360);
			this.GB_AutoUpdate.Name = "GB_AutoUpdate";
			this.GB_AutoUpdate.Size = new System.Drawing.Size(561, 169);
			this.GB_AutoUpdate.TabIndex = 21;
			this.GB_AutoUpdate.TabStop = false;
			this.GB_AutoUpdate.Text = "圓餅圖刷新速率";
			// 
			// RB_AutoUpdateSlow
			// 
			this.RB_AutoUpdateSlow.AutoSize = true;
			this.RB_AutoUpdateSlow.Location = new System.Drawing.Point(6, 100);
			this.RB_AutoUpdateSlow.Name = "RB_AutoUpdateSlow";
			this.RB_AutoUpdateSlow.Size = new System.Drawing.Size(302, 34);
			this.RB_AutoUpdateSlow.TabIndex = 6;
			this.RB_AutoUpdateSlow.Text = "每五筆資料才刷新圓餅圖";
			this.RB_AutoUpdateSlow.UseVisualStyleBackColor = true;
			// 
			// RB_AutoUpdateFast
			// 
			this.RB_AutoUpdateFast.AutoSize = true;
			this.RB_AutoUpdateFast.Checked = true;
			this.RB_AutoUpdateFast.Location = new System.Drawing.Point(5, 54);
			this.RB_AutoUpdateFast.Name = "RB_AutoUpdateFast";
			this.RB_AutoUpdateFast.Size = new System.Drawing.Size(350, 34);
			this.RB_AutoUpdateFast.TabIndex = 5;
			this.RB_AutoUpdateFast.TabStop = true;
			this.RB_AutoUpdateFast.Text = "每一筆資料加入都刷新圓餅圖";
			this.RB_AutoUpdateFast.UseVisualStyleBackColor = true;
			// 
			// Btn_LogLoc
			// 
			this.Btn_LogLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Btn_LogLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_LogLoc.Location = new System.Drawing.Point(160, 10);
			this.Btn_LogLoc.Name = "Btn_LogLoc";
			this.Btn_LogLoc.Size = new System.Drawing.Size(419, 39);
			this.Btn_LogLoc.TabIndex = 20;
			this.Btn_LogLoc.UseVisualStyleBackColor = false;
			this.Btn_LogLoc.Click += new System.EventHandler(this.Btn_LogLoc_Click);
			// 
			// TB_CleanLog
			// 
			this.TB_CleanLog.Location = new System.Drawing.Point(110, 310);
			this.TB_CleanLog.Name = "TB_CleanLog";
			this.TB_CleanLog.Size = new System.Drawing.Size(100, 39);
			this.TB_CleanLog.TabIndex = 19;
			this.TB_CleanLog.Text = "30";
			this.TB_CleanLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TB_CleanLog.TextChanged += new System.EventHandler(this.TB_CleanLog_TextChanged);
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
			this.Timer_RegularAlarm.Tick += new System.EventHandler(this.Timer_RegularAlarm_Tick);
			// 
			// Form1
			// 
			this.AccessibleDescription = "TimeHelper";
			this.AccessibleName = "TimeHelper";
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 669);
			this.Controls.Add(this.Btn_Stop);
			this.Controls.Add(this.Btn_Start);
			this.Controls.Add(this.MTC);
			this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(31, 100, 31, 33);
			this.Resizable = false;
			this.Text = "Time Helper";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MTC.ResumeLayout(false);
			this.TabPage_Main.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Chart_Main)).EndInit();
			this.TabPage_TODO.ResumeLayout(false);
			this.TabPage_TODO.PerformLayout();
			this.TabPage_Setting.ResumeLayout(false);
			this.TabPage_Setting.PerformLayout();
			this.GB_AutoUpdate.ResumeLayout(false);
			this.GB_AutoUpdate.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer Timer_GetData;
		private MetroFramework.Controls.MetroTabControl MTC;
		private System.Windows.Forms.TabPage TabPage_Main;
		private System.Windows.Forms.TabPage TabPage_Setting;
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
		private System.Windows.Forms.Button Btn_LogLoc;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Main;
		private System.Windows.Forms.GroupBox GB_AutoUpdate;
		private System.Windows.Forms.RadioButton RB_AutoUpdateSlow;
		private System.Windows.Forms.RadioButton RB_AutoUpdateFast;
		private System.Windows.Forms.TabPage TabPage_TODO;
		private System.Windows.Forms.CheckedListBox CLB_TODO;
		private System.Windows.Forms.Button Btn_addtodo;
		private System.Windows.Forms.TextBox TB_addtodo;
		private System.Windows.Forms.Label lbl_addtodo;
        private System.Windows.Forms.CheckBox CB_AutoRun;
	}
}

