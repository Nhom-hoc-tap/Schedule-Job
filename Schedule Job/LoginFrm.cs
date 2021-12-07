using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Job
{
	public partial class LoginFrm : Form
	{
		public LoginFrm()
		{
			InitializeComponent();
		}

		private void LoginFrm_Load(object sender, EventArgs e)
		{
			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private void LoginFrm_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void lblForgotPassW_Click(object sender, EventArgs e)
		{
			ForgotPassWordForm fgpFrm = new ForgotPassWordForm();
			fgpFrm.Show();
		}

		private void lblCreateAccount_Click(object sender, EventArgs e)
		{
			CreateAccountFrm cafrm = new CreateAccountFrm();
			cafrm.Show();
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
