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

            pie_chart.Series["s1"].Label = "#PERCENT";
            pie_chart.Titles.Add(((TypeOfJob)cbb_type_of_job.SelectedItem).Name);
            pie_chart.Titles[0].Font = new Font("Microsoft Sans Serif", 10);
            pie_chart.Series["s1"].IsValueShownAsLabel = true;
            if (jobComplete>0)
                pie_chart.Series["s1"].Points.AddXY("Hoàn thành (%)", (Math.Round(((double)jobComplete / (double)sum) * 100)).ToString());
            if (jobOngoing > 0)
                pie_chart.Series["s1"].Points.AddXY("Đang tiến hành (%)", (Math.Round(((double)jobOngoing / (double)sum) * 100)).ToString());
            if (jobDrop > 0)
                pie_chart.Series["s1"].Points.AddXY("Quá hạn (%)", (Math.Round(((double)jobDrop / (double)sum) * 100)).ToString());
            if (jobOver > 0)
                pie_chart.Series["s1"].Points.AddXY("Tạm dừng (%)", (Math.Round(((double)jobOver / (double)sum) * 100)).ToString());

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

        private void lv_detail_Click(object sender, EventArgs e)
        {
            lv_job.Items.Clear();
            if (jobComplete > 0)
            {
                List<Job> jobs = _jobBL.GetByAccount(_current_account_name);
                jobs = jobs.FindAll(x => x.TypeOfJobId == ((TypeOfJob)cbb_type_of_job.SelectedItem).Id);
                jobs = jobs.FindAll(x => x.Status == 1);
                //MessageBox.Show(jobs.Count.ToString());
                if (jobs.Count > 0)
                {
                    foreach (Job j in jobs)
                    {
                        ListViewItem listViewItem = new ListViewItem(j.Id.ToString());
                        listViewItem.SubItems.Add(j.Name.ToString());
                        listViewItem.SubItems.Add(CountJob(j).ToString());
                        lv_job.Items.Add(listViewItem);
                    }
                }
            }
        }

        private void lv_job_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_job_detail.Items.Clear();
            if (lv_job.SelectedItems.Count > 0)
            {
                int jobId = int.Parse( lv_job.SelectedItems[0].SubItems[0].Text);
                
                List<JobDetail> jobDetails = _jobDetailBL.GetByJobId(jobId);
                if (jobDetails.Count > 0)
                {
                    foreach(JobDetail jd in jobDetails)
                    {
                        ListViewItem listViewItem = new ListViewItem(jd.Id.ToString());
                        listViewItem.SubItems.Add(jd.Name);
                        listViewItem.SubItems.Add((jd.EstimateTime - jd.ActualTime).ToString());
                        lv_job_detail.Items.Add(listViewItem);
                    }
                }
            }
        }
    }
}
