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
			this.btn_start = new System.Windows.Forms.Button();
			this.btn_End = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.Timer_GetData = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// btn_start
			// 
			this.btn_start.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_start.Location = new System.Drawing.Point(12, 12);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(262, 131);
			this.btn_start.TabIndex = 0;
			this.btn_start.Text = "Timer Start";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.button_start_Click);
			// 
			// btn_End
			// 
			this.btn_End.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_End.Location = new System.Drawing.Point(12, 149);
			this.btn_End.Name = "btn_End";
			this.btn_End.Size = new System.Drawing.Size(262, 131);
			this.btn_End.TabIndex = 1;
			this.btn_End.Text = "Timer Pause";
			this.btn_End.UseVisualStyleBackColor = true;
			this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 18;
			this.listBox1.Location = new System.Drawing.Point(280, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(360, 274);
			this.listBox1.TabIndex = 2;
			// 
			// Timer_GetData
			// 
			this.Timer_GetData.Interval = 1000;
			this.Timer_GetData.Tick += new System.EventHandler(this.Timer_GetData_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 301);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btn_End);
			this.Controls.Add(this.btn_start);
			this.Name = "Form1";
			this.Text = "Time Helper";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.Button btn_End;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Timer Timer_GetData;
	}
}

