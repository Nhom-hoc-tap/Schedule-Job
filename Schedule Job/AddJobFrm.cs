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
    public partial class AddJobFrm : Form
    {
        private Account account;

        public AddJobFrm()
        {
            InitializeComponent();
        }

        public AddJobFrm(Account account) : this()
        {
            this.account = account;
        }

        private void AddJobFrm_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void LoadCategory()
        {
            cbbCategory.DataSource = TypeOfJobBL.Instance.GetByAccount(account.UserName);
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "Id";
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddTypeofJobFrm addtypeFrm = new AddTypeofJobFrm(account);
            if (addtypeFrm.ShowDialog() == DialogResult.OK)
            {
                LoadCategory();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void AddJobFrm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private Job GetJob()
        {
            int typeId = (int)cbbCategory.SelectedValue;
            string name = txtName.Text;
            DateTime startDate = dtpStartDate.Value + dtpStartTime.Value.TimeOfDay;
            DateTime endDate = dtpEndDate.Value + dtpEndTime.Value.TimeOfDay;
            int priority = cbbPriority.SelectedIndex;
            string description = txtDescription.Text;
            int status = GetStatus();
            return new Job()
            {
                Name = name,
                StartTime = startDate,
                EndTime = endDate,
                Priority = priority,
                Description = description,
                Status = status
            };
        }

        private int GetStatus()
        {
            if (rbComplete.Checked)
            {
                return (int)Status.Complete;
            }

            if (rbDrop.Checked)
            {
                return (int)Status.Drop;
            }

            if (rbOver.Checked)
            {
                return (int)Status.Over;
            }

            return (int)Status.OnGoing;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                Job job = GetJob();
                if (JobBL.Instance.Insert(job))
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private bool ValidateUserInput()
        {
            if (cbbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Không được để trống loại công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Không được để trống tên công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
