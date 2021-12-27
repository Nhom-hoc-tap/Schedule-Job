using BusinessLogic;
using DataAccess;
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
	public partial class CreateAccountFrm : Form
	{
		public CreateAccountFrm()
		{
			InitializeComponent();
		}

		private void CreateAccountFrm_Load(object sender, EventArgs e)
		{
			MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();

		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private void CreateAccountFrm_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private Account GetAccount()
        {
			string fullName = txtFullName.Text;
			string userName = txtUserName.Text;
			string password = txtPassword.Text;
			bool gender = rbMale.Checked;
			DateTime birth = dtpBirth.Value;
			string question = cbbQuestion.Text;
			string answer = txtAnswer.Text;
			return new Account()
			{
				UserName = userName,
				Password = password,
				FullName = fullName,
				Gender = gender,
				Birth = birth,
				Question = question,
				Answer = answer
            };
        }

        private void btnCreate_Click(object sender, EventArgs e)
		{
            if (ValidateUserInput())
            {
				if (AccountBL.Instance.Insert(GetAccount()))
                {
					MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
				}
            }
			this.Close();
		}

		private bool ValidateUserInput()
        {
			if (string.IsNullOrWhiteSpace(txtFullName.Text))
			{
				MessageBox.Show("Không được để trống họ và tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtUserName.Text))
			{
				MessageBox.Show("Không được để trống tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (AccountBL.Instance.HasAccount(txtUserName.Text))
			{
				MessageBox.Show("Đã có tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("Không được để trống mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (txtPassword.Text != txtConfimPassword.Text)
			{
				MessageBox.Show("Mật khẩu nhập lại không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if(string.IsNullOrWhiteSpace(txtAnswer.Text))
			{
				MessageBox.Show("Không được để trống câu trả lời nhằm tìm lại mật khẩu khi bạn quên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}
    }
}
