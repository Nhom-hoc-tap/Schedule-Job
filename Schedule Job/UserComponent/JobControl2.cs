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
        public JobControl2()
        {
            InitializeComponent();
        }
        public void SetData(Job job)
        {
            lbl_job_name.Text = job.Name;
            lbl_value_time_start.Text = job.StartTime.ToString();
            lbl_value_time_finish.Text = job.EndTime.ToString();
            cpb_job_progress.Value = job.Progress;
            cpb_job_progress.Text = job.Progress.ToString() + "%";
            if (job.Progress >= 70)
            {
                cpb_job_progress.ProgressColor = Color.Green;
            }
            else if (job.Progress >= 30)
            {
                cpb_job_progress.ProgressColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                cpb_job_progress.ProgressColor = Color.Red;
            }
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
    }
}
