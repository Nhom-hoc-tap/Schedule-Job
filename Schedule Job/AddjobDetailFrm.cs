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
	public partial class AddjobDetailFrm : Form
	{
		public AddjobDetailFrm()
		{
			InitializeComponent();
		}

        private void btnCancel_Click(object sender, EventArgs e)
        {
			Close();
        }

        private JobDetail GetJobDetail()
        {
            string name = txtName.Text;
            int estimateTime = int.Parse(txtEstimatedTime.Text);
            int actualTime = int.Parse(txtActualTime.Text);
            int priority = cbbPriority.SelectedIndex;
            string desctiption = txtDesciption.Text;
            int status = GetStatus();
            return new JobDetail()
            {
                Name = name,
                EstimateTime = estimateTime,
                ActualTime = actualTime,
                Priority = priority,
                Description = desctiption,
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                JobDetail jobDetail = GetJobDetail();
            }
        }

        private bool ValidateUserInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Không được để trống tên công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
