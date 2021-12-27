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
        private int _current_job_id = 0;
        private int _current_type_of_job_id = 0;
        private int _current_job_detail_id = 0;

        private int _prv_type_job_id;

        private DayControl _clicked_day_control;

        private int _month, _year;

        private List<Job> _list_job;
        private List<JobDetail> _list_job_detail;
        private List<TypeOfJob> _list_TypeOfJob;

        private JobBL _jobBL;
        private JobDetailBL _jobDetailBL;
        private TypeOfJobBL _typeOfJobBL;

        private string userName;

        public MainForm()
        {
            _jobBL = JobBL.Instance;
            _jobDetailBL = JobDetailBL.Instance;
            _typeOfJobBL = TypeOfJobBL.Instance;
            InitializeComponent();
        }

        public MainForm(string userName) : this()
        {
            this.userName = userName;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _list_job = _jobBL.GetByAccount(userName);
            _list_job = _list_job.OrderBy(x => x.Progress).ToList();
            if (_list_job.Count > 0)
            {
                _current_job_id = _list_job[0].Id;
            }

            LoadTypeOfJobs();
            cbb_type_jobs.SelectedValue = 0;

            LoadJobs(_list_job);
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
            List<Job> jobs = _jobBL.GetByAccount(userName);
            if (_current_type_of_job_id > 0)
                jobs = jobs.FindAll(x => x.TypeOfJobId == _current_type_of_job_id);

            if (ckb_search_job.Checked == true && jobs != null)
                LoadJobs(jobs.FindAll(x => x.Name.ToLower().Contains(str)));
            if (ckb_search_job_detail.Checked == true && _list_job_detail != null)
                LoadJobDetail(_list_job_detail.FindAll(x => x.Name.ToLower().Contains(str)));
        }

        private void LoadJobs(List<Job> jobs)
        {
            fpn_jobs.Controls.Clear();
            jobs = jobs.OrderBy(x => x.Priority).ToList();
            jobs.Reverse();
            foreach (Job j in jobs)
            {
                JobControl2 jobControl2 = new JobControl2(j);
                jobControl2.Tag = j.Id;
                jobControl2.Click += JobControl2_Click;
                jobControl2.ContextMenuStrip = cms_job;

                fpn_jobs.Controls.Add(jobControl2);
            }
            lbl_num_job.Text = jobs.Count().ToString();
        }

        private void JobControl2_Click(object sender, EventArgs e)
        {
            _current_job_id = int.Parse((sender as JobControl2).Tag.ToString());
            LoadJobDetail(_list_job_detail = _jobDetailBL.GetByJobId(_current_job_id));

            ShowCurrentSelectedJob();
        }

        private void ShowCurrentSelectedJob()
        {
            foreach (Control c in fpn_jobs.Controls)
            {
                if (c is JobControl2 jobControl2)
                {
                    if (jobControl2.Tag.ToString() == _current_job_id.ToString())
                    {
                        jobControl2.OnClick();
                    }
                    else
                    {
                        jobControl2.NotClick();
                    }
                }
            }
        }

        private void ShowCurrentSelectedJobDetail()
        {
            foreach (Control c in fpn_job_detail.Controls)
            {
                if (c is JobDetailControl)
                {
                    if (((JobDetailControl)c).Tag.ToString() == _current_job_detail_id.ToString())
                        ((JobDetailControl)c).OnClick();
                    else
                        ((JobDetailControl)c).NotClick();
                }
            }
        }

        private void LoadJobDetail(List<JobDetail> jobDetails)
        {
            fpn_job_detail.Controls.Clear();
            foreach (JobDetail jd in jobDetails)
            {
                JobDetailControl jobDetailControl = new JobDetailControl(jd);
                jobDetailControl.ContextMenuStrip = cms_job_detail;
                jobDetailControl.Tag = jd.Id.ToString();
                jobDetailControl.Click += JobDetailControl_Click;

                //if (_jobBL.GetById(_current_job_id).Status == -1 || _jobBL.GetById(_current_job_id).Status == 2)
                //    jobDetailControl.ContextMenuStrip.Items[0].Enabled = false;
                //else
                //    jobDetailControl.ContextMenuStrip.Items[0].Enabled = true;

                fpn_job_detail.Controls.Add(jobDetailControl);
            }
            lbl_num_job_detail.Text = jobDetails.Count().ToString();
        }

        private void JobDetailControl_Click(object sender, EventArgs e)
        {
            _current_job_detail_id = int.Parse((sender as JobDetailControl).Tag.ToString());
            ShowCurrentSelectedJobDetail();
        }

        private void LoadTypeOfJobs()
        {
            _list_TypeOfJob = _typeOfJobBL.GetByAccount(userName);
            _list_TypeOfJob = _list_TypeOfJob.OrderBy(x => x.Name).ToList();
            _list_TypeOfJob.Add(new TypeOfJob { Id = 0, Name = "Tất cả", UserName = userName });

            cbb_type_jobs.ValueMember = "Id";
            cbb_type_jobs.DataSource = _list_TypeOfJob;
            cbb_type_jobs.DisplayMember = "Name";

            toolTip1.SetToolTip(cbb_type_jobs, "Loại công việc");
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "Nhập tên...")
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
                if (_current_type_of_job_id > 0)
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
                ckb_search_by_date.Checked = false;
                ckb_search_by_date.Enabled = false;
                // ckb_status_over.Enabled = false;
            }
            else
            {
                //lbl_date_start.Enabled = true;
                //lbl_date_end.Enabled = true;
                //dtp_start.Enabled = true;
                //dtp_end.Enabled = true;
                ckb_search_by_date.Enabled = true;
                //ckb_status_over.Enabled = true;
            }
        }

        private void ckb_search_progress_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_search_progress.Checked == true)
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
            if (ckb_search_by_date.Checked == true)
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
                ckb_search_by_date.Checked = false;
                ckb_search_by_date.Enabled = false;
                // ckb_status_over.Enabled = false;
            }
            else
            {
                //lbl_date_start.Enabled = true;
                //lbl_date_end.Enabled = true;
                //dtp_start.Enabled = true;
                //dtp_end.Enabled = true;
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
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheweek; i++)
            {
                BlankDay blankDay = new BlankDay();
                fpn_display_calendar.Controls.Add(blankDay);
            }
            for (int i = 1; i <= days; i++)
            {
                List<Job> jobs = _jobBL.GetByAccount(userName);
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
            _clicked_day_control = sender as DayControl;
            _current_type_of_job_id = 0;
            cbb_type_jobs.SelectedValue = 0;
            LoadJobsVer2(jobs);
        }

        private void tsm_count_Click(object sender, EventArgs e)
        {
            StatisticalForm statisticalForm = new StatisticalForm(userName);
            statisticalForm.Show();
        }

        private void btn_add_job_Click(object sender, EventArgs e)
        {
            _prv_type_job_id = _current_type_of_job_id;
            AddJobFrm form = new AddJobFrm(userName, null, _current_type_of_job_id);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadTypeOfJobs();
                cbb_type_jobs.SelectedValue = _prv_type_job_id;
                _list_job = _jobBL.GetByAccount(userName);
                if (_current_type_of_job_id == 0)
                {
                    LoadJobs(_list_job);
                }
                else
                {
                    LoadJobs(_list_job.FindAll(x => x.TypeOfJobId == _current_type_of_job_id));
                }
                DisplayCalendar(_month, _year);
            }
        }

        private void btn_add_jod_detail_Click(object sender, EventArgs e)
        {
            AddjobDetailFrm form = new AddjobDetailFrm(_current_job_id);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _list_job_detail = _jobDetailBL.GetByJobId(_current_job_id);
                LoadJobDetail(_list_job_detail);
                if (_current_type_of_job_id > 0)
                    LoadJobs(_jobBL.GetByAccount(userName).FindAll(x => x.TypeOfJobId == _current_type_of_job_id).ToList());
                else
                    LoadJobs(_jobBL.GetByAccount(userName));
                ShowCurrentSelectedJob();
            }
        }

        private void tsm_update_job_Click(object sender, EventArgs e)
        {
            _prv_type_job_id = _current_type_of_job_id;
            AddJobFrm form = new AddJobFrm(userName, _current_job_id);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadTypeOfJobs();
                cbb_type_jobs.SelectedValue = _prv_type_job_id;
                _list_job = _jobBL.GetByAccount(userName);
                if (_current_type_of_job_id == 0)
                {
                    LoadJobs(_list_job);
                }
                else
                {
                    LoadJobs(_list_job.FindAll(x => x.TypeOfJobId == _current_type_of_job_id));
                }
                DisplayCalendar(_month, _year);
            }
        }

        private void tsm_set_to_drop_Click(object sender, EventArgs e)
        {
            if (_list_job.FindAll(x => x.Status == 0 && x.Id == _current_job_id).Count > 0)
            {
                _jobBL.SetStatus(_current_job_id, 2);
                _list_job = _jobBL.GetByAccount(userName);
                List<Job> jobs = _list_job.FindAll(x => x.TypeOfJobId == _current_type_of_job_id);
                if (_current_type_of_job_id == 0)
                    jobs = _jobBL.GetByAccount(userName);
                LoadJobs(jobs);
                List<JobDetail> jobDetails = _jobDetailBL.GetByJobId(_current_job_id);
                foreach (var jd in jobDetails)
                    if (jd.Status == 0)
                        _jobDetailBL.SetStatus(jd.Id, 2);
                LoadJobDetail(_jobDetailBL.GetByJobId(_current_job_id));
                ShowCurrentSelectedJob();
            }
        }

        private void tsm_set_job_to_ongoing_Click(object sender, EventArgs e)
        {
            if (_list_job.FindAll(x => x.Status == 2 && x.Id == _current_job_id).Count > 0)
            {
                _jobBL.SetStatus(_current_job_id, 0);
                _list_job = _jobBL.GetByAccount(userName);
                List<Job> jobs = _list_job.FindAll(x => x.TypeOfJobId == _current_type_of_job_id);
                if (_current_type_of_job_id == 0)
                    jobs = _jobBL.GetByAccount(userName);
                LoadJobs(jobs);
                List<JobDetail> jobDetails = _jobDetailBL.GetByJobId(_current_job_id);
                foreach (var jd in jobDetails)
                    if (jd.Status == 2)
                        _jobDetailBL.SetStatus(jd.Id, 0);
                LoadJobDetail(_jobDetailBL.GetByJobId(_current_job_id));
                ShowCurrentSelectedJob();
            }
        }

        private void tsm_delete_job_Click(object sender, EventArgs e)
        {
            _jobBL.Delete(_current_job_id);
            _current_job_id = 0;
            _list_job = _jobBL.GetByAccount(userName);
            if (_current_type_of_job_id == 0)
                LoadJobs(_list_job);
            LoadJobs(_list_job.FindAll(x => x.TypeOfJobId == _current_type_of_job_id));
            fpn_job_detail.Controls.Clear();
            DisplayCalendar(_month, _year);
        }

        private void tsm_add_job_detail_Click(object sender, EventArgs e)
        {
            btn_add_jod_detail.PerformClick();
        }

        private void tsm_update_job_detail_Click(object sender, EventArgs e)
        {
            AddjobDetailFrm form = new AddjobDetailFrm(_current_job_id, _current_job_detail_id);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _list_job_detail = _jobDetailBL.GetByJobId(_current_job_id);
                LoadJobDetail(_list_job_detail);
                if (_current_type_of_job_id > 0)
                    LoadJobs(_jobBL.GetByAccount(userName).FindAll(x => x.TypeOfJobId == _current_type_of_job_id).ToList());
                else
                    LoadJobs(_jobBL.GetByAccount(userName));
                ShowCurrentSelectedJob();
            }
        }

        private void tsm_delete_job_detail_Click(object sender, EventArgs e)
        {
            if (_current_job_detail_id == 0)
                return;
            _jobDetailBL.Delete(_current_job_detail_id);
            _current_job_detail_id = 0;
            LoadJobDetail(_list_job_detail = _jobDetailBL.GetByJobId(_current_job_id));
        }

        private void tsm_set_job_detail_to_drop_Click(object sender, EventArgs e)
        {
            if (_list_job_detail.FindAll(x => x.Status == 0 && x.Id == _current_job_detail_id).Count > 0)
            {
                _jobDetailBL.SetStatus(_current_job_detail_id, 2);
                LoadJobDetail(_list_job_detail = _jobDetailBL.GetByJobId(_current_job_id));
                ShowCurrentSelectedJobDetail();
            }
        }

        private void tsm_set_to_ongoing_Click(object sender, EventArgs e)
        {
            if (_list_job_detail.FindAll(x => x.Status == 2 && x.Id == _current_job_detail_id).Count > 0)
            {
                _jobDetailBL.SetStatus(_current_job_detail_id, 0);
                LoadJobDetail(_list_job_detail = _jobDetailBL.GetByJobId(_current_job_id));
                ShowCurrentSelectedJobDetail();
            }
        }

        private void cbb_type_jobs_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedTypeId = Convert.ToInt32(cbb_type_jobs.SelectedValue);
            _current_type_of_job_id = selectedTypeId;
            List<Job> jobs = new List<Job>();
            jobs = selectedTypeId == 0 ? _jobBL.GetByAccount(userName) : _list_job.FindAll(x => (x.TypeOfJobId == selectedTypeId));
            LoadJobs(jobs);
        }

        private void LoadJobsVer2(List<Job> jobs)
        {
            fpn_jobs.Controls.Clear();
            if (jobs.Count > 0)
            {
                int current_type_id = 0;

                jobs = jobs.OrderBy(x => x.TypeOfJobId).ToList();
                current_type_id = jobs[0].TypeOfJobId;

                Label labelDes = new Label();
                labelDes.AutoSize = false;
                labelDes.Font = new Font("Microsoft Sans Serif", 10);
                labelDes.Text = _list_TypeOfJob.Find(x => x.Id == current_type_id).Name;
                labelDes.Size = new Size(200, 20);
                fpn_jobs.Controls.Add(labelDes);

                foreach (Job j in jobs)
                {
                    JobControl2 jobControl2 = new JobControl2(j);
                    jobControl2.Tag = j.Id;
                    jobControl2.Click += JobControl2_Click;

                    jobControl2.ContextMenuStrip = cms_job;

                    if (j.TypeOfJobId != current_type_id)
                    {
                        current_type_id = j.TypeOfJobId;

                        Label label = new Label();
                        label.AutoSize = false;
                        label.Text = _list_TypeOfJob.Find(x => x.Id == current_type_id).Name;
                        label.Font = new Font("Microsoft Sans Serif", 10);
                        label.Size = new Size(200, 20);
                        fpn_jobs.Controls.Add(label);
                    }
                    fpn_jobs.Controls.Add(jobControl2);
                }
                lbl_num_job.Text = jobs.Count().ToString();
                fpn_job_detail.Controls.Clear();
            }
        }
    }
}
