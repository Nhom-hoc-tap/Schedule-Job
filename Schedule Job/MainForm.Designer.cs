
namespace Schedule_Job
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.fpn_job_detail = new System.Windows.Forms.FlowLayoutPanel();
            this.fpn_jobs = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_type_jobs = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_num_job = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_num_job_detail = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.ckb_search_job = new System.Windows.Forms.CheckBox();
            this.ckb_search_job_detail = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckb_search_progress = new System.Windows.Forms.CheckBox();
            this.ckb_search_by_date = new System.Windows.Forms.CheckBox();
            this.txt_progress_end = new System.Windows.Forms.TextBox();
            this.txt_progress_start = new System.Windows.Forms.TextBox();
            this.ckb_status_drop = new System.Windows.Forms.CheckBox();
            this.ckb_status_over = new System.Windows.Forms.CheckBox();
            this.ckb_status_on_going = new System.Windows.Forms.CheckBox();
            this.ckb_priority_false = new System.Windows.Forms.CheckBox();
            this.ckb_status_complete = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.ckb_priority_true = new System.Windows.Forms.CheckBox();
            this.lbl_date_end = new System.Windows.Forms.Label();
            this.lbl_progress_1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_date_start = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_add_jod_detail = new System.Windows.Forms.Button();
            this.btn_add_job = new System.Windows.Forms.Button();
            this.fpn_display_calendar = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_month_year = new System.Windows.Forms.Label();
            this.btn_prev_month = new System.Windows.Forms.Button();
            this.btn_next_month = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpn_job_detail
            // 
            this.fpn_job_detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fpn_job_detail.AutoScroll = true;
            this.fpn_job_detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpn_job_detail.Location = new System.Drawing.Point(519, 262);
            this.fpn_job_detail.Name = "fpn_job_detail";
            this.fpn_job_detail.Size = new System.Drawing.Size(660, 552);
            this.fpn_job_detail.TabIndex = 4;
            // 
            // fpn_jobs
            // 
            this.fpn_jobs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fpn_jobs.AutoScroll = true;
            this.fpn_jobs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpn_jobs.Location = new System.Drawing.Point(10, 262);
            this.fpn_jobs.Name = "fpn_jobs";
            this.fpn_jobs.Size = new System.Drawing.Size(503, 552);
            this.fpn_jobs.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_next_month);
            this.panel1.Controls.Add(this.btn_prev_month);
            this.panel1.Controls.Add(this.lbl_month_year);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fpn_display_calendar);
            this.panel1.Location = new System.Drawing.Point(1185, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 801);
            this.panel1.TabIndex = 5;
            // 
            // cbb_type_jobs
            // 
            this.cbb_type_jobs.BackColor = System.Drawing.Color.White;
            this.cbb_type_jobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_type_jobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_type_jobs.FormattingEnabled = true;
            this.cbb_type_jobs.Location = new System.Drawing.Point(9, 228);
            this.cbb_type_jobs.Name = "cbb_type_jobs";
            this.cbb_type_jobs.Size = new System.Drawing.Size(459, 28);
            this.cbb_type_jobs.TabIndex = 7;
            this.cbb_type_jobs.SelectedIndexChanged += new System.EventHandler(this.cbb_type_jobs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(7, 817);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số công việc :";
            // 
            // lbl_num_job
            // 
            this.lbl_num_job.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_num_job.Location = new System.Drawing.Point(114, 817);
            this.lbl_num_job.Name = "lbl_num_job";
            this.lbl_num_job.Size = new System.Drawing.Size(101, 23);
            this.lbl_num_job.TabIndex = 9;
            this.lbl_num_job.Text = "...";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(518, 817);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số chi tiết công việc :";
            // 
            // lbl_num_job_detail
            // 
            this.lbl_num_job_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_num_job_detail.Location = new System.Drawing.Point(692, 817);
            this.lbl_num_job_detail.Name = "lbl_num_job_detail";
            this.lbl_num_job_detail.Size = new System.Drawing.Size(101, 23);
            this.lbl_num_job_detail.TabIndex = 9;
            this.lbl_num_job_detail.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(497, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 67);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo tên";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(22, 26);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(651, 27);
            this.txt_search.TabIndex = 0;
            this.txt_search.Text = "Nhập tên...";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // ckb_search_job
            // 
            this.ckb_search_job.AutoSize = true;
            this.ckb_search_job.Checked = true;
            this.ckb_search_job.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_search_job.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_search_job.Location = new System.Drawing.Point(134, 26);
            this.ckb_search_job.Name = "ckb_search_job";
            this.ckb_search_job.Size = new System.Drawing.Size(105, 24);
            this.ckb_search_job.TabIndex = 1;
            this.ckb_search_job.Text = "Công việc";
            this.ckb_search_job.UseVisualStyleBackColor = true;
            this.ckb_search_job.CheckedChanged += new System.EventHandler(this.ckb_search_job_CheckedChanged);
            // 
            // ckb_search_job_detail
            // 
            this.ckb_search_job_detail.AutoSize = true;
            this.ckb_search_job_detail.Checked = true;
            this.ckb_search_job_detail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_search_job_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_search_job_detail.Location = new System.Drawing.Point(284, 26);
            this.ckb_search_job_detail.Name = "ckb_search_job_detail";
            this.ckb_search_job_detail.Size = new System.Drawing.Size(160, 24);
            this.ckb_search_job_detail.TabIndex = 1;
            this.ckb_search_job_detail.Text = "Chi tiết công việc";
            this.ckb_search_job_detail.UseVisualStyleBackColor = true;
            this.ckb_search_job_detail.CheckedChanged += new System.EventHandler(this.ckb_search_job_detail_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckb_search_progress);
            this.groupBox2.Controls.Add(this.ckb_search_by_date);
            this.groupBox2.Controls.Add(this.txt_progress_end);
            this.groupBox2.Controls.Add(this.txt_progress_start);
            this.groupBox2.Controls.Add(this.ckb_status_drop);
            this.groupBox2.Controls.Add(this.ckb_status_over);
            this.groupBox2.Controls.Add(this.ckb_status_on_going);
            this.groupBox2.Controls.Add(this.ckb_priority_false);
            this.groupBox2.Controls.Add(this.ckb_status_complete);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.ckb_priority_true);
            this.groupBox2.Controls.Add(this.lbl_date_end);
            this.groupBox2.Controls.Add(this.lbl_progress_1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbl_progress);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbl_date_start);
            this.groupBox2.Controls.Add(this.dtp_end);
            this.groupBox2.Controls.Add(this.dtp_start);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1167, 136);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm theo ...";
            // 
            // ckb_search_progress
            // 
            this.ckb_search_progress.AutoSize = true;
            this.ckb_search_progress.Checked = true;
            this.ckb_search_progress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_search_progress.Location = new System.Drawing.Point(578, 34);
            this.ckb_search_progress.Name = "ckb_search_progress";
            this.ckb_search_progress.Size = new System.Drawing.Size(18, 17);
            this.ckb_search_progress.TabIndex = 9;
            this.ckb_search_progress.UseVisualStyleBackColor = true;
            this.ckb_search_progress.CheckedChanged += new System.EventHandler(this.ckb_search_progress_CheckedChanged);
            // 
            // ckb_search_by_date
            // 
            this.ckb_search_by_date.AutoSize = true;
            this.ckb_search_by_date.Checked = true;
            this.ckb_search_by_date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_search_by_date.Location = new System.Drawing.Point(578, 62);
            this.ckb_search_by_date.Name = "ckb_search_by_date";
            this.ckb_search_by_date.Size = new System.Drawing.Size(18, 17);
            this.ckb_search_by_date.TabIndex = 9;
            this.ckb_search_by_date.UseVisualStyleBackColor = true;
            this.ckb_search_by_date.CheckedChanged += new System.EventHandler(this.ckb_search_by_date_CheckedChanged);
            // 
            // txt_progress_end
            // 
            this.txt_progress_end.Location = new System.Drawing.Point(1037, 29);
            this.txt_progress_end.Name = "txt_progress_end";
            this.txt_progress_end.Size = new System.Drawing.Size(119, 27);
            this.txt_progress_end.TabIndex = 3;
            // 
            // txt_progress_start
            // 
            this.txt_progress_start.Location = new System.Drawing.Point(757, 29);
            this.txt_progress_start.Name = "txt_progress_start";
            this.txt_progress_start.Size = new System.Drawing.Size(117, 27);
            this.txt_progress_start.TabIndex = 3;
            // 
            // ckb_status_drop
            // 
            this.ckb_status_drop.AutoSize = true;
            this.ckb_status_drop.Location = new System.Drawing.Point(361, 96);
            this.ckb_status_drop.Name = "ckb_status_drop";
            this.ckb_status_drop.Size = new System.Drawing.Size(105, 24);
            this.ckb_status_drop.TabIndex = 2;
            this.ckb_status_drop.Text = "Tạm dừng";
            this.ckb_status_drop.UseVisualStyleBackColor = true;
            // 
            // ckb_status_over
            // 
            this.ckb_status_over.AutoSize = true;
            this.ckb_status_over.Location = new System.Drawing.Point(179, 96);
            this.ckb_status_over.Name = "ckb_status_over";
            this.ckb_status_over.Size = new System.Drawing.Size(94, 24);
            this.ckb_status_over.TabIndex = 2;
            this.ckb_status_over.Text = "Quá hạn";
            this.ckb_status_over.UseVisualStyleBackColor = true;
            // 
            // ckb_status_on_going
            // 
            this.ckb_status_on_going.AutoSize = true;
            this.ckb_status_on_going.Location = new System.Drawing.Point(361, 66);
            this.ckb_status_on_going.Name = "ckb_status_on_going";
            this.ckb_status_on_going.Size = new System.Drawing.Size(143, 24);
            this.ckb_status_on_going.TabIndex = 2;
            this.ckb_status_on_going.Text = "Đang tiến hành";
            this.ckb_status_on_going.UseVisualStyleBackColor = true;
            // 
            // ckb_priority_false
            // 
            this.ckb_priority_false.AutoSize = true;
            this.ckb_priority_false.Location = new System.Drawing.Point(361, 31);
            this.ckb_priority_false.Name = "ckb_priority_false";
            this.ckb_priority_false.Size = new System.Drawing.Size(162, 24);
            this.ckb_priority_false.TabIndex = 2;
            this.ckb_priority_false.Text = "Không quan trọng";
            this.ckb_priority_false.UseVisualStyleBackColor = true;
            // 
            // ckb_status_complete
            // 
            this.ckb_status_complete.AutoSize = true;
            this.ckb_status_complete.Location = new System.Drawing.Point(179, 66);
            this.ckb_status_complete.Name = "ckb_status_complete";
            this.ckb_status_complete.Size = new System.Drawing.Size(117, 24);
            this.ckb_status_complete.TabIndex = 2;
            this.ckb_status_complete.Text = "Hoàn thành";
            this.ckb_status_complete.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Image = global::Schedule_Job.Properties.Resources.icons8_search_24;
            this.btn_search.Location = new System.Drawing.Point(1080, 96);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(77, 34);
            this.btn_search.TabIndex = 8;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // ckb_priority_true
            // 
            this.ckb_priority_true.AutoSize = true;
            this.ckb_priority_true.Location = new System.Drawing.Point(179, 31);
            this.ckb_priority_true.Name = "ckb_priority_true";
            this.ckb_priority_true.Size = new System.Drawing.Size(114, 24);
            this.ckb_priority_true.TabIndex = 2;
            this.ckb_priority_true.Text = "Quan trọng";
            this.ckb_priority_true.UseVisualStyleBackColor = true;
            // 
            // lbl_date_end
            // 
            this.lbl_date_end.AutoSize = true;
            this.lbl_date_end.Location = new System.Drawing.Point(945, 62);
            this.lbl_date_end.Name = "lbl_date_end";
            this.lbl_date_end.Size = new System.Drawing.Size(81, 20);
            this.lbl_date_end.TabIndex = 1;
            this.lbl_date_end.Text = "Kết thúc :";
            // 
            // lbl_progress_1
            // 
            this.lbl_progress_1.AutoSize = true;
            this.lbl_progress_1.Location = new System.Drawing.Point(945, 32);
            this.lbl_progress_1.Name = "lbl_progress_1";
            this.lbl_progress_1.Size = new System.Drawing.Size(39, 20);
            this.lbl_progress_1.TabIndex = 1;
            this.lbl_progress_1.Text = "Đến";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(560, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1, 90);
            this.label9.TabIndex = 1;
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.Location = new System.Drawing.Point(602, 32);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(124, 20);
            this.lbl_progress.TabIndex = 1;
            this.lbl_progress.Text = "Tiến độ           :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Trạng thái       :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Độ quan trọng :";
            // 
            // lbl_date_start
            // 
            this.lbl_date_start.AutoSize = true;
            this.lbl_date_start.Location = new System.Drawing.Point(602, 62);
            this.lbl_date_start.Name = "lbl_date_start";
            this.lbl_date_start.Size = new System.Drawing.Size(122, 20);
            this.lbl_date_start.TabIndex = 1;
            this.lbl_date_start.Text = "Bắt đầu          :";
            // 
            // dtp_end
            // 
            this.dtp_end.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(1037, 62);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(119, 27);
            this.dtp_end.TabIndex = 0;
            // 
            // dtp_start
            // 
            this.dtp_start.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(755, 62);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(119, 27);
            this.dtp_start.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckb_search_job_detail);
            this.groupBox3.Controls.Add(this.ckb_search_job);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 67);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn để tìm kiếm";
            // 
            // btn_add_jod_detail
            // 
            this.btn_add_jod_detail.Image = global::Schedule_Job.Properties.Resources.icons8_add_24;
            this.btn_add_jod_detail.Location = new System.Drawing.Point(1141, 225);
            this.btn_add_jod_detail.Name = "btn_add_jod_detail";
            this.btn_add_jod_detail.Size = new System.Drawing.Size(38, 34);
            this.btn_add_jod_detail.TabIndex = 8;
            this.btn_add_jod_detail.UseVisualStyleBackColor = true;
            // 
            // btn_add_job
            // 
            this.btn_add_job.Image = global::Schedule_Job.Properties.Resources.icons8_add_24;
            this.btn_add_job.Location = new System.Drawing.Point(475, 227);
            this.btn_add_job.Name = "btn_add_job";
            this.btn_add_job.Size = new System.Drawing.Size(38, 34);
            this.btn_add_job.TabIndex = 8;
            this.btn_add_job.UseVisualStyleBackColor = true;
            // 
            // fpn_display_calendar
            // 
            this.fpn_display_calendar.Location = new System.Drawing.Point(3, 81);
            this.fpn_display_calendar.Name = "fpn_display_calendar";
            this.fpn_display_calendar.Size = new System.Drawing.Size(342, 300);
            this.fpn_display_calendar.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Su";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(54, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mo";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(105, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tu";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(156, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "We";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(207, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Th";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(258, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Fr";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(300, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Sa";
            // 
            // lbl_month_year
            // 
            this.lbl_month_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_month_year.Location = new System.Drawing.Point(87, 24);
            this.lbl_month_year.Name = "lbl_month_year";
            this.lbl_month_year.Size = new System.Drawing.Size(177, 23);
            this.lbl_month_year.TabIndex = 2;
            this.lbl_month_year.Text = "MonthYear";
            this.lbl_month_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_prev_month
            // 
            this.btn_prev_month.Location = new System.Drawing.Point(6, 24);
            this.btn_prev_month.Name = "btn_prev_month";
            this.btn_prev_month.Size = new System.Drawing.Size(75, 23);
            this.btn_prev_month.TabIndex = 3;
            this.btn_prev_month.Text = "<<";
            this.btn_prev_month.UseVisualStyleBackColor = true;
            this.btn_prev_month.Click += new System.EventHandler(this.btn_prev_month_Click);
            // 
            // btn_next_month
            // 
            this.btn_next_month.Location = new System.Drawing.Point(270, 24);
            this.btn_next_month.Name = "btn_next_month";
            this.btn_next_month.Size = new System.Drawing.Size(75, 23);
            this.btn_next_month.TabIndex = 3;
            this.btn_next_month.Text = ">>";
            this.btn_next_month.UseVisualStyleBackColor = true;
            this.btn_next_month.Click += new System.EventHandler(this.btn_next_month_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_num_job_detail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_num_job);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add_jod_detail);
            this.Controls.Add(this.btn_add_job);
            this.Controls.Add(this.cbb_type_jobs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fpn_job_detail);
            this.Controls.Add(this.fpn_jobs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Quản Lý Công Việc";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpn_job_detail;
        private System.Windows.Forms.FlowLayoutPanel fpn_jobs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbb_type_jobs;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_add_job;
        private System.Windows.Forms.Button btn_add_jod_detail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_num_job;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_num_job_detail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.CheckBox ckb_search_job_detail;
        private System.Windows.Forms.CheckBox ckb_search_job;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label lbl_date_end;
        private System.Windows.Forms.Label lbl_date_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.CheckBox ckb_priority_false;
        private System.Windows.Forms.CheckBox ckb_priority_true;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckb_status_drop;
        private System.Windows.Forms.CheckBox ckb_status_over;
        private System.Windows.Forms.CheckBox ckb_status_on_going;
        private System.Windows.Forms.CheckBox ckb_status_complete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_progress;
        private System.Windows.Forms.TextBox txt_progress_end;
        private System.Windows.Forms.TextBox txt_progress_start;
        private System.Windows.Forms.Label lbl_progress_1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.CheckBox ckb_search_progress;
        private System.Windows.Forms.CheckBox ckb_search_by_date;
        private System.Windows.Forms.FlowLayoutPanel fpn_display_calendar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_month_year;
        private System.Windows.Forms.Button btn_next_month;
        private System.Windows.Forms.Button btn_prev_month;
    }
}

