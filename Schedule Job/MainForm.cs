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
using System.Globalization;

namespace Schedule_Job
{
    public partial class MainForm : Form
    {
        private string _current_account_name = "Nguyễn Văn A";
        private int _current_job_id = 0;
        private int _current_type_of_job_id = 0;

        private int _month, _year;

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
            _typeOfJobBL = new TypeOfJobBL();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _list_job = _jobBL.GetByAccount(_current_account_name);
            _list_job = _list_job.OrderBy(x=>x.Progress).ToList();
            _current_job_id = _list_job[0].TypeOfJobId;
            LoadJobs(_list_job);
            LoadTypeOfJobs();

            txt_search.GotFocus += Txt_search_GotFocus;
            txt_search.LostFocus += Txt_search_LostFocus;

            DateTime now = DateTime.Now;
            _month = now.Month;
            _year = now.Year;
            DisplayCalendar(_month, _year);
        }

        private void Txt_search_LostFocus(object sender, EventArgs e)
        {
            txt_search.Text = "Nhập tên...";
        }

        private void Txt_search_GotFocus(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }

        private void Search(string str)
        {
            List<Job> jobs = _jobBL.GetByAccount(_current_account_name);
            if(_current_type_of_job_id >0)
                jobs = jobs.FindAll(x => x.TypeOfJobId == _current_type_of_job_id);

            if (ckb_search_job.Checked == true && jobs!=null)
                LoadJobs(jobs.FindAll(x => x.Name.ToLower().Contains(str)));
            if (ckb_search_job_detail.Checked == true && _list_job_detail !=null)
                LoadJobDetail(_list_job_detail.FindAll(x => x.Name.ToLower().Contains(str)));
        }

        private void LoadJobs(List<Job> jobs)
        {
            fpn_jobs.Controls.Clear();
            jobs =  jobs.OrderBy(x => x.Priority).ToList();
            jobs.Reverse();
            foreach(Job j in jobs)
            {
                JobControl2 jobControl2 = new JobControl2(j);
                jobControl2.Tag = j.Id;
                jobControl2.Click += JobControl2_Click;
                fpn_jobs.Controls.Add(jobControl2);
            }
            lbl_num_job.Text = jobs.Count().ToString();
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
            lbl_num_job_detail.Text = jobDetails.Count().ToString();
        }

        private void LoadTypeOfJobs()
        {
            _list_TypeOfJob = _typeOfJobBL.GetByAccount(_current_account_name);
            _list_TypeOfJob = _list_TypeOfJob.OrderBy(x => x.Name).ToList();
            _list_TypeOfJob.Add(new TypeOfJob { Id = 0, Name = "Tất cả", UserName = _current_account_name });
            cbb_type_jobs.DataSource = _list_TypeOfJob;
            cbb_type_jobs.ValueMember = "Id";
            cbb_type_jobs.DisplayMember = "Name";

            toolTip1.SetToolTip(cbb_type_jobs, "Loại công việc");

            _current_type_of_job_id = _list_TypeOfJob[0].Id;
        }

        private void cbb_type_jobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTypeId= ((TypeOfJob) cbb_type_jobs.SelectedItem).Id;
            _current_type_of_job_id = selectedTypeId;
            List<Job> jobs = new List<Job>();
            if (selectedTypeId == 0)
                jobs = _jobBL.GetByAccount(_current_account_name);
            else jobs = _list_job.FindAll(x => (x.TypeOfJobId == selectedTypeId));
            LoadJobs(jobs);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if(txt_search.Text!="Nhập tên...")
            Search(txt_search.Text.ToLower());
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //SearchByUnit();
            if (ckb_search_job.Checked == true) SearchJob();
            if (ckb_search_job_detail.Checked == true) SearchJobDetail();

        }

        private void SearchJob()
        {
            if (_list_job != null)
            {
                List<Job> jobs = _list_job;
                if(_current_type_of_job_id >0)
                    jobs = _list_job.FindAll(x => x.TypeOfJobId == _current_type_of_job_id);
                if (ckb_priority_true.Checked == true)
                    jobs = jobs.FindAll(x => x.Priority == 1);
                if (ckb_priority_false.Checked == true)
                    jobs = jobs.FindAll(x => x.Priority == 0);
                if (ckb_status_complete.Checked == true)
                    jobs = jobs.FindAll(x => x.Status == 1);
                if (ckb_status_on_going.Checked == true)
                    jobs = jobs.FindAll(x => x.Status == 0);
                if (ckb_status_over.Checked == true)
                    jobs = jobs.FindAll(x => x.Status == -1);
                if (ckb_status_drop.Checked == true)
                    jobs = jobs.FindAll(x => x.Status == 2);
                if (ckb_search_progress.Checked == true)
                {
                    int min = 0;
                    int max = 100;
                    try
                    {
                        min = int.Parse(txt_progress_start.Text);
                        max = int.Parse(txt_progress_end.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Giá trị tiến độ không hợp lệ", "Lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    jobs = jobs.FindAll(x => (x.Progress >= min && x.Progress <= max));
                }
                if (ckb_search_by_date.Checked == true)
                {
                    jobs = jobs.FindAll(x => (x.StartTime >= dtp_start.Value && x.EndTime <= dtp_end.Value));
                }
                LoadJobs(jobs);
            }
        }

        private void SearchJobDetail()
        {
            if (_list_job_detail != null)
            {
                List<JobDetail> jobDetails = _list_job_detail.FindAll(x => x.JobId == _current_job_id);
                if (ckb_priority_true.Checked == true)
                    jobDetails = jobDetails.FindAll(x => x.Priority == 1);
                if (ckb_priority_false.Checked == true)
                    jobDetails = jobDetails.FindAll(x => x.Priority == 0);
                if (ckb_status_complete.Checked == true)
                    jobDetails = jobDetails.FindAll(x => x.Status == 1);
                if (ckb_status_on_going.Checked == true)
                    jobDetails = jobDetails.FindAll(x => x.Status == 0);
                if (ckb_status_drop.Checked == true)
                    jobDetails = jobDetails.FindAll(x => x.Status == 2);
                if (ckb_status_over.Checked == true)
                    jobDetails = jobDetails.FindAll(x => x.Status == -1);
                if (ckb_search_progress.Checked == true)
                {
                    int min = 0;
                    int max = 100;
                    try
                    {
                        min = int.Parse(txt_progress_start.Text);
                        max = int.Parse(txt_progress_end.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Giá trị tiến độ không hợp lệ", "Lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    jobDetails = jobDetails.FindAll(x => (x.Progress >= min && x.Progress <= max));
                }
                LoadJobDetail(jobDetails);
            }
        }

        private void ckb_search_job_detail_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_search_job_detail.Checked == true && ckb_search_job.Checked == false)
            {
                lbl_date_start.Enabled = false;
                lbl_date_end.Enabled = false;
                dtp_start.Enabled = false;
                dtp_end.Enabled = false;
                ckb_search_by_date.Enabled = false;
                // ckb_status_over.Enabled = false;
            }
            else
            {
                lbl_date_start.Enabled = true;
                lbl_date_end.Enabled = true;
                dtp_start.Enabled = true;
                dtp_end.Enabled = true;
                ckb_search_by_date.Enabled = true;
                //ckb_status_over.Enabled = true;
            }
        }

        private void ckb_search_progress_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_search_progress.Checked == true)
            {
                lbl_progress.Enabled = true;
                lbl_progress_1.Enabled = true;
                txt_progress_start.Enabled = true;
                txt_progress_end.Enabled = true;
            }
            else
            {
                lbl_progress.Enabled = false;
                lbl_progress_1.Enabled = false;
                txt_progress_start.Enabled = false;
                txt_progress_end.Enabled = false;
            }
        }

        private void ckb_search_by_date_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_search_by_date.Checked == true)
            {
                lbl_date_start.Enabled = true;
                lbl_date_end.Enabled = true;
                dtp_start.Enabled = true;
                dtp_end.Enabled = true;
            }
            else
            {
                lbl_date_start.Enabled = false;
                lbl_date_end.Enabled = false;
                dtp_start.Enabled = false;
                dtp_end.Enabled = false;
            }
        }

        private void ckb_search_job_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_search_job_detail.Checked == true && ckb_search_job.Checked == false)
            {
                lbl_date_start.Enabled = false;
                lbl_date_end.Enabled = false;
                dtp_start.Enabled = false;
                dtp_end.Enabled = false;
                ckb_search_by_date.Enabled = false;
                // ckb_status_over.Enabled = false;
            }
            else
            {
                lbl_date_start.Enabled = true;
                lbl_date_end.Enabled = true;
                dtp_start.Enabled = true;
                dtp_end.Enabled = true;
                ckb_search_by_date.Enabled = true;
                //ckb_status_over.Enabled = true;
            }
        }

        private void btn_prev_month_Click(object sender, EventArgs e)
        {
            if (_month == 1)
            {
                _month = 12;
                _year--;
            }
            else
            {
                _month--;
            }
            DisplayCalendar(_month, _year);
        }

        private void btn_next_month_Click(object sender, EventArgs e)
        {
            if (_month == 12)
            {
                _month = 1;
                _year++;
            }
            else
            {
                _month++;
            }
            DisplayCalendar(_month, _year);
        }

        private void DisplayCalendar(int month, int year)
        {

            fpn_display_calendar.Controls.Clear();
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_month_year.Text = monthname + " " + year.ToString();

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;
            for(int i =1; i<dayoftheweek; i++)
            {
                BlankDay blankDay = new BlankDay();
                fpn_display_calendar.Controls.Add(blankDay);
            }
            for(int i=1; i <= days; i++)
            {
                List<Job> jobs = _jobBL.GetByAccount(_current_account_name);
                jobs = jobs.FindAll(x => (x.EndTime.Day == i && x.EndTime.Month == month && x.EndTime.Year == year));
                DayControl dayControl = new DayControl(jobs);
                dayControl.Days(i);
                if (jobs.Count > 0)
                {
                    dayControl.Click += DayControl_Click;
                }
                if (i == DateTime.Now.Day && month == DateTime.Now.Month && year == DateTime.Now.Year)
                    dayControl.BorderStyle = BorderStyle.FixedSingle;
                fpn_display_calendar.Controls.Add(dayControl);
            }
        }

        private void DayControl_Click(object sender, EventArgs e)
        {
            List<Job> jobs = (sender as DayControl).jobs;
            cbb_type_jobs.Text = "Tất cả";
            LoadJobsVer2(jobs);
            
        }
        private void LoadJobsVer2(List<Job> jobs)
        {
            fpn_jobs.Controls.Clear();

            int current_type_id = 0;

            jobs = jobs.OrderBy(x => x.TypeOfJobId).ToList();
            current_type_id = jobs[0].TypeOfJobId;

            Label labelDes = new Label();
            labelDes.AutoSize = false;
            labelDes.Size = new Size(500, 20);
            labelDes.Font = new Font("Microsoft Sans Serif", 10);
            labelDes.Text = _list_TypeOfJob.Find(x => x.Id == current_type_id).Name;
            fpn_jobs.Controls.Add(labelDes);

            foreach (Job j in jobs)
            {
                JobControl2 jobControl2 = new JobControl2(j);
                jobControl2.Tag = j.Id;
                jobControl2.Click += JobControl2_Click;

                if(j.TypeOfJobId != current_type_id)
                {
                    current_type_id = j.TypeOfJobId;

                    Label label = new Label();
                    label.AutoSize = false;
                    label.Size = new Size(500, 20);
                    label.Text = _list_TypeOfJob.Find(x => x.Id == current_type_id).Name;
                    label.Font = new Font("Microsoft Sans Serif", 10);

                    fpn_jobs.Controls.Add(label);
                }
                fpn_jobs.Controls.Add(jobControl2);
            }
            lbl_num_job.Text = jobs.Count().ToString();
        }
    }
}
