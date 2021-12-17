using BusinessLogic;
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
        private int jobDetailId;

        private int jobId;

		public AddjobDetailFrm()
		{
			InitializeComponent();
		}

        public AddjobDetailFrm(int jobId, int? jobDetailId = null) : this()
        {
            this.jobId = jobId;
            this.jobDetailId = jobDetailId ?? 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
			Close();
        }

        private JobDetail GetJobDetailById(int id)
        {
            return id > 0 ? JobDetailBL.Instance.GetById(id) : null;
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
                JobId = jobId,
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
                var newJobDetail = GetJobDetail();
                var oldJobDetail = GetJobDetailById(jobDetailId);
                if (oldJobDetail is null)
                {
                    JobDetailBL.Instance.Insert(newJobDetail);
                }
                else
                {
                    JobDetailBL.Instance.Update(newJobDetail);
                }
                DialogResult = DialogResult.OK;
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

		private void AddjobDetailFrm_Load(object sender, EventArgs e)
		{

		}
	}
}
