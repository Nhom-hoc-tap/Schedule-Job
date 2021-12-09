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
	public partial class AddTypeofJobFrm : Form
	{
		private Account account;

		public AddTypeofJobFrm()
		{
			InitializeComponent();
		}

		public AddTypeofJobFrm(Account account) : this()
        {
			this.account = account;
        }

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void AddTypeofJobFrm_Load(object sender, EventArgs e)
		{
			
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();

		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private void AddTypeofJobFrm_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

        private void btnSave_Click(object sender, EventArgs e)
        {
			if (ValidateUserInput())
            {
				TypeOfJob typeOfJob = new TypeOfJob()
                {
					Name = txtName.Text,
					UserName = account.UserName
                };

				if (TypeOfJobBL.Instance.Insert(typeOfJob))
                {
					DialogResult = DialogResult.OK;
				}
			}
        }

		private bool ValidateUserInput()
		{
			if (string.IsNullOrWhiteSpace(txtName.Text))
			{
				MessageBox.Show("Không được để trống tên loại công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}
	}
}
