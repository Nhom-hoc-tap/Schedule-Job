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
            if (_jobDetail.Status == 0)
            {
                lbl_progress.Text = _jobDetail.Progress.ToString() + "/100%";
                lbl_progress.ForeColor = Color.FromArgb(255, 128, 0);
            }
            else if(_jobDetail.Status == 1)
            {
                lbl_progress.Text = "Hoàn thành";
                lbl_progress.Font = new Font("Microsoft Sans Serif", 8);
                lbl_progress.ForeColor = Color.Green;
            }
            else
            {
                lbl_progress.Text = "Tạm dừng";
                lbl_progress.Font = new Font("Microsoft Sans Serif", 8);
                lbl_progress.ForeColor = Color.Gray;
            }
            if(_jobDetail.Priority ==0)
            {
                pb_priority.Visible = false;
            }
            if (_jobDetail.Priority == 1)
            {
                pb_priority.Visible = true;
                pb_priority.Image = Properties.Resources.icons8_star_filled;
            }
        }
        private string GetTime(int value)
        {
            string result = "";
            
            if (value == 0)
                result = "Chưa khả dụng";
            if (value < 60 && value >0)
                result = value + " phút";
            if(value >=60)
            {
                int h = value / 60;
                int m = (int)(((double)value / 60 - h) * 60);
                result = h + " giờ, " + m + " phút";
            }
            return result;
        }

        private void JobDetailControl_Load(object sender, EventArgs e)
        {
            setData();
        }
    }
}
