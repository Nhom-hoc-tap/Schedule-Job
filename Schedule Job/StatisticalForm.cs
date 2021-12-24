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
using BusinessLogic;

namespace Schedule_Job
{
    public partial class StatisticalForm : Form
    {
        private TypeOfJobBL _typeOfJobBL;
        private JobBL _jobBL;
        private JobDetailBL _jobDetailBL;
        private string _current_account_name;
        int sum = 0;
        int jobComplete = 0;
        int jobOngoing = 0;
        int jobDrop = 0;
        int jobOver = 0;
        public StatisticalForm(string accountName)
        {
            _current_account_name = accountName;
            _typeOfJobBL = TypeOfJobBL.Instance;
            _jobBL = JobBL.Instance;
            _jobDetailBL = JobDetailBL.Instance;
            InitializeComponent();
        }
        private void StatisticalForm_Load(object sender, EventArgs e)
        {
            LoadTypeOfJob();
        }
        private void LoadTypeOfJob()
        {
            List<TypeOfJob> typeOfJobs = _typeOfJobBL.GetByAccount(_current_account_name);
            cbb_type_of_job.DataSource = typeOfJobs;
            cbb_type_of_job.DisplayMember = "Name";
            cbb_type_of_job.ValueMember = "Id";
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            pie_chart.Series.Clear();
            pie_chart.Series.Add("s1").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            pie_chart.Titles.Clear();
            List<Job> jobs = _jobBL.GetByAccount(_current_account_name);
            int selectedTypeId = ((TypeOfJob)cbb_type_of_job.SelectedItem).Id;
            jobs = jobs.FindAll(x => x.TypeOfJobId == selectedTypeId);
            jobs = jobs.FindAll(x => (x.StartTime >= dtp_start.Value && x.EndTime <= dtp_end.Value));

            if(jobs.FindAll(x => x.Status == 1)!=null)
                jobComplete = jobs.FindAll(x => x.Status == 1).Count;
            if(jobs.FindAll(x => x.Status == 0) !=null)
                jobOngoing = jobs.FindAll(x => x.Status == 0).Count;
            if (jobs.FindAll(x => x.Status == 2) != null)
                jobDrop = jobs.FindAll(x => x.Status == 2).Count;
            if (jobs.FindAll(x => x.Status == -1) != null)
                jobOver = jobs.FindAll(x => x.Status == -1).Count;
            sum = jobComplete + jobOngoing + jobOver + jobDrop;

            //pie_chart.Series["s1"].Label = "#PERCENT";
            pie_chart.Titles.Add(((TypeOfJob)cbb_type_of_job.SelectedItem).Name);
            pie_chart.Titles[0].Font = new Font("Microsoft Sans Serif", 10);
            pie_chart.Series["s1"].IsValueShownAsLabel = true;
            if (jobComplete>0)
                pie_chart.Series["s1"].Points.AddXY("Hoàn thành (%)", (Math.Round(((double)jobComplete / (double)sum) * 100)).ToString());
            if (jobOngoing > 0)
                pie_chart.Series["s1"].Points.AddXY("Đang tiến hành (%)", (Math.Round(((double)jobOngoing / (double)sum) * 100)).ToString());
            if (jobDrop > 0)
                pie_chart.Series["s1"].Points.AddXY("Tạm dừng (%)", (Math.Round(((double)jobDrop / (double)sum) * 100)).ToString());
            if (jobOver > 0)
                pie_chart.Series["s1"].Points.AddXY("Quá hạn (%)", (Math.Round(((double)jobOver / (double)sum) * 100)).ToString());

            lv_detail.Items.Clear();

            ListViewItem listViewItem = new ListViewItem("Hoàn thành");
            listViewItem.SubItems.Add(jobComplete.ToString());
            lv_detail.Items.Add(listViewItem);

            listViewItem = new ListViewItem("Đang tiến hành");
            listViewItem.SubItems.Add(jobOngoing.ToString());
            lv_detail.Items.Add(listViewItem);

            listViewItem = new ListViewItem("Quá hạn");
            listViewItem.SubItems.Add(jobOver.ToString());
            lv_detail.Items.Add(listViewItem);

            listViewItem = new ListViewItem("Tạm dừng");
            listViewItem.SubItems.Add(jobDrop.ToString());
            lv_detail.Items.Add(listViewItem);

            listViewItem = new ListViewItem("Tổng");
            listViewItem.SubItems.Add(sum.ToString());
            lv_detail.Items.Add(listViewItem);

        }
        private string CountTime(DateTime d1, DateTime d2)
        {
            //DateTime d1 = DateTime.Now ;//new DateTime(2021, 12, 8, 7, 0, 0);
            //DateTime d2 = job.EndTime;//DateTime.Now;
            TimeSpan tp = d2 - d1;
            double tM = tp.TotalMinutes;
            int D = ((int)tM / 60) / 24;
            int H = (int)((((tM / 60) / 24) - D) * 24);
            int M = (int)((((((tM / 60) / 24) - D) * 24) - H) * 60);
            string kq = "";
            kq += D + " ngày, " + H + " giờ, " + M + " phút";
            return kq;
        }
        private int CountJob(Job job)
        {
            int kq = 0;
            List<JobDetail> jobDetails = _jobDetailBL.GetByJobId(job.Id);
            if (jobDetails.Count > 0)
            { 
                foreach (JobDetail jd in jobDetails)
                {
                    kq += jd.EstimateTime - jd.ActualTime;
                }
            }
            return kq;
        }
        private void lv_job_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_job.SelectedItems.Count > 0)
            {
                ResetInfo();
                switch (lv_detail.SelectedItems[0].SubItems[0].Text)
                {
                    case "Hoàn thành":
                        LoadJobDetailComplete(int.Parse(lv_job.SelectedItems[0].SubItems[0].Text));
                        break;
                    case "Đang tiến hành":
                        LoadJobDetailOngoning(int.Parse(lv_job.SelectedItems[0].SubItems[0].Text));
                        break;
                    case "Quá hạn":
                        LoadJobDetailOver(int.Parse(lv_job.SelectedItems[0].SubItems[0].Text));
                        break;
                    case "Tạm dừng":
                        LoadJobDetailDrop(int.Parse(lv_job.SelectedItems[0].SubItems[0].Text));
                        break;
                    default: break;
                }
            }
        }
        private void SetInfo(List<JobDetail> jobDetails)
        {
            int complete = jobDetails.FindAll(x => x.Status == 1).Count;
            int ongoing = jobDetails.FindAll(x => x.Status == 0).Count;
            int over = jobDetails.FindAll(x => x.Status == -1).Count;
            int drop = jobDetails.FindAll(x => x.Status == 2).Count;

            lbl_num_complete.Text = complete.ToString();
            lbl_num_ongoing.Text = ongoing.ToString();
            lbl_num_over.Text = over.ToString();
            lbl_num_drop.Text = drop.ToString();

        }
        private void ResetInfo()
        {
            lbl_num_complete.Text = "...";
            lbl_num_ongoing.Text = "...";
            lbl_num_over.Text = "...";
            lbl_num_drop.Text = "...";
        }
        private void LoadJobDetailComplete(int jobId)
        {
            lv_job_detail.Items.Clear();
            List<JobDetail> jobDetails = _jobDetailBL.GetByJobId(jobId);
            if (jobDetails.Count > 0)
            {
                foreach (JobDetail jd in jobDetails)
                {
                    ListViewItem listViewItem = new ListViewItem(jd.Id.ToString());
                    listViewItem.SubItems.Add(jd.Name);
                    listViewItem.SubItems.Add("Đã hoàn thành, Tiết kiệm: " + (jd.EstimateTime - jd.ActualTime).ToString()+" phút");
                    lv_job_detail.Items.Add(listViewItem);
                }
                SetInfo(jobDetails);
            }
        }
        private void LoadJobDetailOngoning(int jobId)
        {
            lv_job_detail.Items.Clear();
            List<JobDetail> jobDetails = _jobDetailBL.GetByJobId(jobId);
            if (jobDetails.Count > 0)
            {
                foreach (JobDetail jd in jobDetails)
                {
                    ListViewItem listViewItem = new ListViewItem(jd.Id.ToString());
                    listViewItem.SubItems.Add(jd.Name);
                    if(jd.Status == 1)
                        listViewItem.SubItems.Add("Đã hoàn thành, Tiết kiệm: "+(jd.ActualTime - jd.EstimateTime).ToString());
                    if(jd.Status == 0)
                        listViewItem.SubItems.Add("Chưa hoàn thành, Dự kiến: " + (jd.EstimateTime).ToString());
                    lv_job_detail.Items.Add(listViewItem);
                }
                SetInfo(jobDetails);
            }
        }
        private void lv_detail_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_job.Items.Clear();
            lv_job_detail.Items.Clear();
            if (lv_detail.SelectedItems.Count > 0)
            {
                ResetInfo();
                switch (lv_detail.SelectedItems[0].SubItems[0].Text)
                {
                    case "Hoàn thành":
                        LoadJobCoplete();
                        break;
                    case "Đang tiến hành":
                        LoadJobOnGoing();
                        break;
                    case "Quá hạn":
                        LoadJobOver();
                        break;
                    case "Tạm dừng":
                        LoadJobDrop();
                        break;
                    default: break;
                }
            }
        }
        private void LoadJobDetailOver(int jobId)
        {
            lv_job_detail.Items.Clear();
            List<JobDetail> jobDetails = _jobDetailBL.GetByJobId(jobId);
            if (jobDetails.Count > 0)
            {
                foreach (JobDetail jd in jobDetails)
                {
                    ListViewItem listViewItem = new ListViewItem(jd.Id.ToString());
                    listViewItem.SubItems.Add(jd.Name);
                    if (jd.ActualTime >0)
                        listViewItem.SubItems.Add("Đã hoàn thành, Tiết kiệm: " + (jd.ActualTime - jd.EstimateTime).ToString());
                    if (jd.ActualTime == 0)
                        listViewItem.SubItems.Add("Chưa hoàn thành");
                    lv_job_detail.Items.Add(listViewItem);
                }
                SetInfo(jobDetails);
            }
        }
        private void LoadJobDetailDrop(int jobId)
        {
            lv_job_detail.Items.Clear();
            List<JobDetail> jobDetails = _jobDetailBL.GetByJobId(jobId);
            if (jobDetails.Count > 0)
            {
                foreach (JobDetail jd in jobDetails)
                {
                    ListViewItem listViewItem = new ListViewItem(jd.Id.ToString());
                    listViewItem.SubItems.Add(jd.Name);
                    listViewItem.SubItems.Add("Tạm dừng");
                    lv_job_detail.Items.Add(listViewItem);
                }
                SetInfo(jobDetails);
            }
        }
        private void LoadJobOver()
        {
            lv_job.Items.Clear();
            if (jobOver > 0)
            {
                List<Job> jobs = _jobBL.GetByAccount(_current_account_name);
                jobs = jobs.FindAll(x => x.TypeOfJobId == ((TypeOfJob)cbb_type_of_job.SelectedItem).Id);
                jobs = jobs.FindAll(x => (x.StartTime >= dtp_start.Value && x.EndTime <= dtp_end.Value));
                jobs = jobs.FindAll(x => x.Status == -1);
                //MessageBox.Show(jobs.Count.ToString());
                if (jobs.Count > 0)
                {
                    foreach (Job j in jobs)
                    {
                        ListViewItem listViewItem = new ListViewItem(j.Id.ToString());
                        listViewItem.SubItems.Add(j.Name.ToString());
                        listViewItem.SubItems.Add("Quá hạn");//:"+CountTime(j.EndTime, DateTime.Now));
                        lv_job.Items.Add(listViewItem);
                    }
                }
            }
        }
        private void LoadJobDrop()
        {
            lv_job.Items.Clear();
            if (jobDrop > 0)
            {
                List<Job> jobs = _jobBL.GetByAccount(_current_account_name);
                jobs = jobs.FindAll(x => x.TypeOfJobId == ((TypeOfJob)cbb_type_of_job.SelectedItem).Id);
                jobs = jobs.FindAll(x => (x.StartTime >= dtp_start.Value && x.EndTime <= dtp_end.Value));
                jobs = jobs.FindAll(x => x.Status == 2);
                //MessageBox.Show(jobs.Count.ToString());
                if (jobs.Count > 0)
                {
                    foreach (Job j in jobs)
                    {
                        ListViewItem listViewItem = new ListViewItem(j.Id.ToString());
                        listViewItem.SubItems.Add(j.Name.ToString());
                        listViewItem.SubItems.Add("Tạm dừng");//:"+CountTime(j.EndTime, DateTime.Now));
                        lv_job.Items.Add(listViewItem);
                    }
                }
            }
        }
        private void LoadJobCoplete()
        {
            lv_job.Items.Clear();
            if (jobComplete > 0)
            {
                List<Job> jobs = _jobBL.GetByAccount(_current_account_name);
                jobs = jobs.FindAll(x => x.TypeOfJobId == ((TypeOfJob)cbb_type_of_job.SelectedItem).Id);
                jobs = jobs.FindAll(x => (x.StartTime >= dtp_start.Value && x.EndTime <= dtp_end.Value));
                jobs = jobs.FindAll(x => x.Status == 1);
                //MessageBox.Show(jobs.Count.ToString());
                if (jobs.Count > 0)
                {
                    foreach (Job j in jobs)
                    {
                        ListViewItem listViewItem = new ListViewItem(j.Id.ToString());
                        listViewItem.SubItems.Add(j.Name.ToString());
                        listViewItem.SubItems.Add("Đã hoàn thành, Tiết kiệm: " + CountJob(j).ToString()+" phút");
                        lv_job.Items.Add(listViewItem);
                    }
                }
            }
        }
        private void LoadJobOnGoing()
        {
            lv_job.Items.Clear();
            if (jobOngoing > 0)
            {
                List<Job> jobs = _jobBL.GetByAccount(_current_account_name);
                jobs = jobs.FindAll(x => x.TypeOfJobId == ((TypeOfJob)cbb_type_of_job.SelectedItem).Id);
                jobs = jobs.FindAll(x => (x.StartTime >= dtp_start.Value && x.EndTime <= dtp_end.Value));
                jobs = jobs.FindAll(x => x.Status == 0);
                //MessageBox.Show(jobs.Count.ToString());
                if (jobs.Count > 0)
                {
                    foreach (Job j in jobs)
                    {
                        ListViewItem listViewItem = new ListViewItem(j.Id.ToString());
                        listViewItem.SubItems.Add(j.Name.ToString());
                        listViewItem.SubItems.Add("Còn lại: "+ CountTime(DateTime.Now, j.EndTime).ToString());
                        lv_job.Items.Add(listViewItem);
                    }
                }
            }
        }
    }
}
