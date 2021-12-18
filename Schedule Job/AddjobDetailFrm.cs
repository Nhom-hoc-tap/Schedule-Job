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


        private void AddjobDetailFrm_Load(object sender, EventArgs e)
        {
            ShowDetailJob();

            nudProgress.Enabled = true;
            nudActualTime.Enabled = false;
            nudActualTime.Value = 0;
            nudProgress.Value = 0;
        }

        private void ShowDetailJob()
        {
            var jobDetail = GetJobDetailById(jobDetailId);
            if (jobDetail is null)
            {
                return;
            }

            txtName.Text = jobDetail.Name;
            nudEstimatedTime.Value = jobDetail.EstimateTime;
            nudActualTime.Value = jobDetail.ActualTime;
            nudProgress.Value = jobDetail.Progress;
            cbbPriority.SelectedIndex = jobDetail.Priority;
            txtDesciption.Text = jobDetail.Description;

            LoadStatus(jobDetail);
        }

        private void LoadStatus(JobDetail jobDetail)
        {
            switch (jobDetail.Status)
            {
                case 1:
                    rbComplete.Checked = true;
                    break;

                case 2:
                    rbDrop.Checked = true;
                    break;

                case -1:
                    rbOver.Checked = true;
                    break;

                default:
                    rbOnGoing.Checked = true;
                    break;
            }
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
            int estimateTime = int.Parse(nudEstimatedTime.Text);
            int actualTime = 0;
            try
            {
                actualTime = int.Parse(nudActualTime.Text);
            }
            catch (Exception ex)
            { }

            int priority = cbbPriority.SelectedIndex;
            string desctiption = txtDesciption.Text;
            int progress = (int)nudProgress.Value;
            int status = GetStatus();
            return new JobDetail()
            {
                Id = jobDetailId,
                JobId = jobId,
                Name = name,
                EstimateTime = estimateTime,
                ActualTime = actualTime,
                Priority = priority,
                Description = desctiption,
                Progress = progress,
                Status = status,

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
            if (nudEstimatedTime.Value == 0)
            {
                MessageBox.Show("Hãy nhập thời gian bạn dự kiến hoàn thành công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if ((rbComplete.Checked == true && nudActualTime.Value == 0) || (rbComplete.Checked == true && nudActualTime.Value == 0))
            {
                MessageBox.Show("Hãy nhập thời gian bạn hoàn thành công việc trong thực tế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void rbComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (rbComplete.Checked == true)
            {
                nudProgress.Value = 100;
                nudProgress.Enabled = false;
                nudActualTime.Enabled = true;
            }
            else
            {
                nudProgress.Enabled = true;
                nudActualTime.Enabled = false;
                nudActualTime.Value = 0;
                nudProgress.Value = 0;
            }
        }
    }
}
