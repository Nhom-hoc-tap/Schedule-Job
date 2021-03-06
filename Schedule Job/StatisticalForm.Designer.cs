
namespace Schedule_Job
{
    partial class StatisticalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_type_of_job = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_date_end = new System.Windows.Forms.Label();
            this.lbl_date_start = new System.Windows.Forms.Label();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.pie_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lv_detail = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_job = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_job_detail = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_num_complete = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_num_ongoing = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_num_over = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_num_drop = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pie_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_type_of_job);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn loại công việc";
            // 
            // cbb_type_of_job
            // 
            this.cbb_type_of_job.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_type_of_job.FormattingEnabled = true;
            this.cbb_type_of_job.Location = new System.Drawing.Point(7, 27);
            this.cbb_type_of_job.Name = "cbb_type_of_job";
            this.cbb_type_of_job.Size = new System.Drawing.Size(346, 28);
            this.cbb_type_of_job.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.lbl_date_end);
            this.groupBox2.Controls.Add(this.lbl_date_start);
            this.groupBox2.Controls.Add(this.dtp_start);
            this.groupBox2.Controls.Add(this.dtp_end);
            this.groupBox2.Location = new System.Drawing.Point(377, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 64);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn khoản thời gian";
            // 
            // btn_search
            // 
            this.btn_search.Image = global::Schedule_Job.Properties.Resources.icons8_search_24;
            this.btn_search.Location = new System.Drawing.Point(669, 21);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(77, 34);
            this.btn_search.TabIndex = 9;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_date_end
            // 
            this.lbl_date_end.AutoSize = true;
            this.lbl_date_end.Location = new System.Drawing.Point(358, 30);
            this.lbl_date_end.Name = "lbl_date_end";
            this.lbl_date_end.Size = new System.Drawing.Size(81, 20);
            this.lbl_date_end.TabIndex = 4;
            this.lbl_date_end.Text = "Kết thúc :";
            // 
            // lbl_date_start
            // 
            this.lbl_date_start.AutoSize = true;
            this.lbl_date_start.Location = new System.Drawing.Point(15, 30);
            this.lbl_date_start.Name = "lbl_date_start";
            this.lbl_date_start.Size = new System.Drawing.Size(122, 20);
            this.lbl_date_start.TabIndex = 5;
            this.lbl_date_start.Text = "Bắt đầu          :";
            // 
            // dtp_start
            // 
            this.dtp_start.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_start.CustomFormat = "dd/MM/yyyy";
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start.Location = new System.Drawing.Point(167, 26);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(117, 27);
            this.dtp_start.TabIndex = 3;
            // 
            // dtp_end
            // 
            this.dtp_end.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_end.CustomFormat = "dd/MM/yyyy";
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_end.Location = new System.Drawing.Point(450, 26);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(119, 27);
            this.dtp_end.TabIndex = 2;
            // 
            // pie_chart
            // 
            chartArea3.Name = "ChartArea1";
            this.pie_chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.pie_chart.Legends.Add(legend3);
            this.pie_chart.Location = new System.Drawing.Point(12, 83);
            this.pie_chart.Name = "pie_chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "s1";
            this.pie_chart.Series.Add(series3);
            this.pie_chart.Size = new System.Drawing.Size(500, 500);
            this.pie_chart.TabIndex = 1;
            this.pie_chart.Text = "chart1";
            // 
            // lv_detail
            // 
            this.lv_detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_detail.FullRowSelect = true;
            this.lv_detail.GridLines = true;
            this.lv_detail.HideSelection = false;
            this.lv_detail.Location = new System.Drawing.Point(519, 83);
            this.lv_detail.Name = "lv_detail";
            this.lv_detail.Size = new System.Drawing.Size(609, 150);
            this.lv_detail.TabIndex = 3;
            this.lv_detail.UseCompatibleStateImageBehavior = false;
            this.lv_detail.View = System.Windows.Forms.View.Details;
            this.lv_detail.SelectedIndexChanged += new System.EventHandler(this.lv_detail_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Trạng thái";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 450;
            // 
            // lv_job
            // 
            this.lv_job.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lv_job.FullRowSelect = true;
            this.lv_job.GridLines = true;
            this.lv_job.HideSelection = false;
            this.lv_job.Location = new System.Drawing.Point(519, 239);
            this.lv_job.Name = "lv_job";
            this.lv_job.Size = new System.Drawing.Size(610, 150);
            this.lv_job.TabIndex = 3;
            this.lv_job.UseCompatibleStateImageBehavior = false;
            this.lv_job.View = System.Windows.Forms.View.Details;
            this.lv_job.SelectedIndexChanged += new System.EventHandler(this.lv_job_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã số";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tên công việc";
            this.columnHeader8.Width = 280;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Thông tin";
            this.columnHeader9.Width = 240;
            // 
            // lv_job_detail
            // 
            this.lv_job_detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10});
            this.lv_job_detail.FullRowSelect = true;
            this.lv_job_detail.GridLines = true;
            this.lv_job_detail.HideSelection = false;
            this.lv_job_detail.Location = new System.Drawing.Point(518, 395);
            this.lv_job_detail.Name = "lv_job_detail";
            this.lv_job_detail.Size = new System.Drawing.Size(610, 168);
            this.lv_job_detail.TabIndex = 3;
            this.lv_job_detail.UseCompatibleStateImageBehavior = false;
            this.lv_job_detail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã số";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên chi tiết công việc";
            this.columnHeader4.Width = 280;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Thông tin";
            this.columnHeader10.Width = 240;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hoàn thành";
            // 
            // lbl_num_complete
            // 
            this.lbl_num_complete.AutoSize = true;
            this.lbl_num_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_complete.Location = new System.Drawing.Point(606, 566);
            this.lbl_num_complete.Name = "lbl_num_complete";
            this.lbl_num_complete.Size = new System.Drawing.Size(20, 17);
            this.lbl_num_complete.TabIndex = 4;
            this.lbl_num_complete.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(647, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đang tiến hành";
            // 
            // lbl_num_ongoing
            // 
            this.lbl_num_ongoing.AutoSize = true;
            this.lbl_num_ongoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_ongoing.Location = new System.Drawing.Point(758, 566);
            this.lbl_num_ongoing.Name = "lbl_num_ongoing";
            this.lbl_num_ongoing.Size = new System.Drawing.Size(20, 17);
            this.lbl_num_ongoing.TabIndex = 4;
            this.lbl_num_ongoing.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(795, 566);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quá hạn";
            // 
            // lbl_num_over
            // 
            this.lbl_num_over.AutoSize = true;
            this.lbl_num_over.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_over.Location = new System.Drawing.Point(864, 566);
            this.lbl_num_over.Name = "lbl_num_over";
            this.lbl_num_over.Size = new System.Drawing.Size(20, 17);
            this.lbl_num_over.TabIndex = 4;
            this.lbl_num_over.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(907, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tạm dừng";
            // 
            // lbl_num_drop
            // 
            this.lbl_num_drop.AutoSize = true;
            this.lbl_num_drop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_drop.Location = new System.Drawing.Point(985, 566);
            this.lbl_num_drop.Name = "lbl_num_drop";
            this.lbl_num_drop.Size = new System.Drawing.Size(20, 17);
            this.lbl_num_drop.TabIndex = 4;
            this.lbl_num_drop.Text = "...";
            // 
            // StatisticalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 596);
            this.Controls.Add(this.lbl_num_drop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_num_over);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_num_ongoing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_num_complete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_job_detail);
            this.Controls.Add(this.lv_job);
            this.Controls.Add(this.lv_detail);
            this.Controls.Add(this.pie_chart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StatisticalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.StatisticalForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pie_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_type_of_job;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_date_end;
        private System.Windows.Forms.Label lbl_date_start;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataVisualization.Charting.Chart pie_chart;
        private System.Windows.Forms.ListView lv_detail;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lv_job;
        private System.Windows.Forms.ListView lv_job_detail;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_num_complete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_num_ongoing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_num_over;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_num_drop;
    }
}