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
        private string _current_account_name = "Nguyễn Văn A";
        private int _current_job_id = 0;

        private List<Job> _list_job;
        private List<JobDetail> _list_job_detail;
        private List<TypeOfJob> _list_TypeOfJob;

        private JobBL _jobBL;
        private JobDetailBL _jobDetailBL;
        private TypeOfJobBL _typeOfJobBL;


        public MainForm()
        {
            _jobBL = new JobBL();
            _jobDetailBL = new JobDetailBL();
            _typeOfJobBL = TypeOfJobBL.Instance;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _list_job = _jobBL.GetByAccount(_current_account_name);
            _list_job = _list_job.OrderBy(x=>x.Progress).ToList();
            _current_job_id = _list_job[0].TypeOfJobId;
            LoadJobs(_list_job);
            LoadTypeOfJobs();
        }
        private void LoadJobs(List<Job> jobs)
        {
            fpn_jobs.Controls.Clear();
            foreach(Job j in jobs)
            {
                JobControl2 jobControl2 = new JobControl2(j);
                jobControl2.Tag = j.Id;
                jobControl2.Click += JobControl2_Click;
                fpn_jobs.Controls.Add(jobControl2);
            }
        }

        private void JobControl2_Click(object sender, EventArgs e)
        {
            _current_job_id = int.Parse( (sender as JobControl2).Tag.ToString());
            LoadJobDetail(_list_job_detail = _jobDetailBL.GetByJobId(_current_job_id));
        }

        private void LoadJobDetail(List<JobDetail> jobDetails)
        {
            fpn_job_detail.Controls.Clear();
            foreach(JobDetail jd in jobDetails)
            {
                JobDetailControl jobDetailControl = new JobDetailControl(jd);
                fpn_job_detail.Controls.Add(jobDetailControl);
            }
        }

        private void LoadTypeOfJobs()
        {
            _list_TypeOfJob = _typeOfJobBL.GetByAccount(_current_account_name);
            cbb_type_jobs.DataSource = _list_TypeOfJob;
            cbb_type_jobs.ValueMember = "Id";
            cbb_type_jobs.DisplayMember = "Name";

            toolTip1.SetToolTip(cbb_type_jobs, "Loại công việc");
        }

        private void cbb_type_jobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTypeId= ((TypeOfJob) cbb_type_jobs.SelectedItem).Id;
            List<Job> jobs = _list_job.FindAll(x => (x.TypeOfJobId == selectedTypeId));
            LoadJobs(jobs);
        }
    }
}
