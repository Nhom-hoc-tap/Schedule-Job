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
using DataAccess;
using BusinessLogic;

namespace Schedule_Job
{
    public partial class MainForm : Form
    {
        private List<Job> _list_job;
        private JobBL _jobBL;
        public MainForm()
        {
            _jobBL = new JobBL();
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
            _list_job = _jobBL.GetAll();
            foreach(Job j in _list_job)
            {
                JobControl2 jobControl2 = new JobControl2();
                jobControl2.SetData(j);
                fpn_jobs.Controls.Add(jobControl2);
            }
            //for (int i = 0; i < 10; i++) {
            //    JobControl2 jobControl2 = new JobControl2();
            //    fpn_jobs.Controls.Add(jobControl2);
            //}
            for (int i = 0; i < 10; i++)
            {
                JobDetailControl jobDetailControl = new JobDetailControl();
                fpn_job_detail.Controls.Add(jobDetailControl);
            }
            
        }

    }
}
