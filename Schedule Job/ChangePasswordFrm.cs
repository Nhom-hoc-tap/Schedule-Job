using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Job
{
	public partial class ChangePasswordFrm : Form
	{
		public ChangePasswordFrm()
		{
			InitializeComponent();
		}

		private void ChangePasswordFrm_Load(object sender, EventArgs e)
		{
			txtTaiKhoan.Text = ForgotPassWordForm.userName;
		}

		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			string userName = txtTaiKhoan.Text;
			string password = txtPassword.Text;
			EditPassword(userName, password);

			
		}

		void EditPassword(string username, string password)
		{
			if(AccountDA.Instance.Update(username,password))
			{
				MessageBox.Show("Cập nhật mật khẩu thành công");
			}
			else
			{
				MessageBox.Show("Cập nhật mật khẩu thất bại");
			}
		}
	}
}
