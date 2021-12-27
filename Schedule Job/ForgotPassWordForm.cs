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
    public partial class ForgotPassWordForm : Form
    {
        public ForgotPassWordForm()
        {
            InitializeComponent();
        }
        public static string userName = "";
        public static string Question = "";
        public static string Answer = "";
        private void ForgotPassWordForm_Load(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ForgotPassWordForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void btnOK_Click(object sender, EventArgs e)
		{
            userName = txtUserName.Text;
            Question = cbbQuestion.Text;
            Answer = txtAnswer.Text;
            ChangePasswordFrm cpf = new ChangePasswordFrm();
            cpf.Show();
		}
	}
}
