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
    public partial class DayControl : UserControl
    {
        public List<Job> jobs;
        public DayControl(List<Job> jobs)
        {
            this.jobs = jobs;
            InitializeComponent();
        }
        public void Days(int day)
        {
            lbl_day.Text = day.ToString();
        }

        private void DayControl_Load(object sender, EventArgs e)
        {
            if (jobs.Count > 0)
            {
                this.BackColor = Color.FromArgb(255, 128, 0);
                string str = "";
                for(int i=0; i< jobs.Count; i++)
                {
                    str += (i+1).ToString()+" : "+ jobs[i].Name+"\n";
                }
                toolTip1.SetToolTip(lbl_day, str);
                toolTip1.AutoPopDelay=15000;
            }
        }
    }
}
