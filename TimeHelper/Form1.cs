using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TimeHelper
{
	public partial class Form1 : Form
	{
		HookFunction hook = new HookFunction();

		public Form1()
		{
			InitializeComponent();
		}

		private void button_start_Click(object sender, EventArgs e)
		{
			Timer_GetData.Enabled = true;
		}

		private void btn_End_Click(object sender, EventArgs e)
		{
			Timer_GetData.Enabled = false;
		}

		private void Timer_GetData_Tick(object sender, EventArgs e)
		{
			listBox1.Items.Add(hook.GetWindowText());
		}

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
