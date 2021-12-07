using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace Schedule_Job.UserComponent
{
    public partial class JobDetailControl : UserControl
    {
        private JobDetail _jobDetail;
        public JobDetailControl(JobDetail jobDetail)
        {
            this._jobDetail = jobDetail;
            InitializeComponent();
        }

        private void setData()
        {
            lbl_name.Text = _jobDetail.Name;
            lbl_description.Text = _jobDetail.Description;
            lbl_estimate_time.Text = GetTime(_jobDetail.EstimateTime);
            lbl_actual_time.Text = GetTime(_jobDetail.ActualTime);
            prg_Progress.Value = _jobDetail.Progress;
            if (_jobDetail.Progress < 100)
            {
                lbl_progress.Text = _jobDetail.Progress.ToString() + "/100%";
                lbl_progress.ForeColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                lbl_progress.Text = "Hoàn thành";
                lbl_progress.Font = new Font("Microsoft Sans Serif", 7);
                lbl_progress.ForeColor = Color.Green;
            }
        }
        private string GetTime(int value)
        {
            string result = "";
            int hours = value / 60;
            if (hours > 0)
                result += hours.ToString() + " giờ ";
            if (value - hours > 0)
                result += (value - hours).ToString() + " phút";
            if (value == 0)
                result = "Chưa khả dụng";
            return result;
        }

        private void JobDetailControl_Load(object sender, EventArgs e)
        {
            setData();
        }
    }
}
