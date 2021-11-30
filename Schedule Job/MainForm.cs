using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schedule_Job.UserComponent;

namespace Schedule_Job
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadJobs();
        }
        private void LoadJobs()
        {
            //jobControl jobControl = new jobControl();
            //fpn_jobs.Controls.Add(jobControl);
            for (int i = 0; i < 10; i++) {
                JobControl2 jobControl2 = new JobControl2();
                fpn_jobs.Controls.Add(jobControl2);
            }
            for (int i = 0; i < 10; i++)
            {
                JobDetailControl jobDetailControl = new JobDetailControl();
                fpn_job_detail.Controls.Add(jobDetailControl);
            }
            
        }

    }
}
