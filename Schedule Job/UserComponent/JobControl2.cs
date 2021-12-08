using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace Schedule_Job.UserComponent
{
    public partial class JobControl2 : UserControl
    {
        private Boolean _clicked = false;
        private Job _job;
        public JobControl2(Job job)
        {
            this._job = job;
            InitializeComponent();
        }
        private void SetData()
        {
            lbl_job_name.Text = _job.Name;
            lbl_description.Text = _job.Description;
            lbl_value_time_start.Text = _job.StartTime.ToString();
            lbl_value_time_finish.Text = _job.EndTime.ToString();
            cpb_job_progress.Value = _job.Progress;
            cpb_job_progress.Text = _job.Progress.ToString() + "%";
            if (_job.Progress >= 70)
            {
                cpb_job_progress.ProgressColor = Color.Green;
            }
            else if (_job.Progress >= 30)
            {
                cpb_job_progress.ProgressColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                cpb_job_progress.ProgressColor = Color.Red;
            }

            if(_job.Priority == 1)
            {
                pb_priority.Image = Properties.Resources.icons8_star_filled;
            }
            else
            {
                pb_priority.Image = Properties.Resources.outline_star_24;
            }

            switch (_job.Status)
            {
                case 0: lbl_status.Text = "Đang tiến hành"; lbl_status.ForeColor = Color.Blue; break;
                case 1: lbl_status.Text = "Hoàn thành"; lbl_status.ForeColor = Color.Green; break;
                case -1: lbl_status.Text = "Quá hạn"; lbl_status.ForeColor = Color.Red; break;
                case 2: lbl_status.Text = "Tạm dừng"; lbl_status.ForeColor = Color.Gray; break;
            }

            toolTip1.SetToolTip(lbl_job_name, _job.Name);
            toolTip1.SetToolTip(lbl_description, _job.Description);
            toolTip1.AutoPopDelay = 15000;
        }
        public void DisplayProgress(Job job)
        {
            for (int i = 0; i <= job.Progress; i++)
            {
                Thread.Sleep(10);
                if (i >= 70)
                {
                    cpb_job_progress.ProgressColor = Color.Green;
                }
                else if (i >= 30)
                {
                    cpb_job_progress.ProgressColor = Color.FromArgb(255, 128, 0);
                }
                else
                {
                    cpb_job_progress.ProgressColor = Color.Red;
                }
                cpb_job_progress.Value = i;
                cpb_job_progress.Text = i.ToString() + "%";
                cpb_job_progress.Update();
            }
        }

       
        private void onClicked(bool clicked)
        {
            _clicked = clicked;
            //if (_clicked == true)
            //    _clicked = false;
            //else _clicked = true;
        }
        private void setToClick()
        {
            //onClicked();
            if (_clicked == true)
                this.BorderStyle = BorderStyle.Fixed3D;
            else
            {
                this.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void JobControl2_Load(object sender, EventArgs e)
        {
            SetData();
        }
    }
}
