
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cbb_type_jobs = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_add_job = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpn_job_detail
            // 
            this.fpn_job_detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fpn_job_detail.AutoScroll = true;
            this.fpn_job_detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpn_job_detail.Location = new System.Drawing.Point(519, 184);
            this.fpn_job_detail.Name = "fpn_job_detail";
            this.fpn_job_detail.Size = new System.Drawing.Size(755, 536);
            this.fpn_job_detail.TabIndex = 4;
            // 
            // fpn_jobs
            // 
            this.fpn_jobs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fpn_jobs.AutoScroll = true;
            this.fpn_jobs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpn_jobs.Location = new System.Drawing.Point(10, 184);
            this.fpn_jobs.Name = "fpn_jobs";
            this.fpn_jobs.Size = new System.Drawing.Size(503, 535);
            this.fpn_jobs.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(1277, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 707);
            this.panel1.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // cbb_type_jobs
            // 
            this.cbb_type_jobs.BackColor = System.Drawing.Color.White;
            this.cbb_type_jobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_type_jobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_type_jobs.FormattingEnabled = true;
            this.cbb_type_jobs.Location = new System.Drawing.Point(10, 150);
            this.cbb_type_jobs.Name = "cbb_type_jobs";
            this.cbb_type_jobs.Size = new System.Drawing.Size(459, 28);
            this.cbb_type_jobs.TabIndex = 7;
            this.cbb_type_jobs.SelectedIndexChanged += new System.EventHandler(this.cbb_type_jobs_SelectedIndexChanged);
            // 
            // btn_add_job
            // 
            this.btn_add_job.Image = global::Schedule_Job.Properties.Resources.icons8_add_24;
            this.btn_add_job.Location = new System.Drawing.Point(475, 149);
            this.btn_add_job.Name = "btn_add_job";
            this.btn_add_job.Size = new System.Drawing.Size(38, 34);
            this.btn_add_job.TabIndex = 8;
            this.btn_add_job.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 730);
            this.Controls.Add(this.btn_add_job);
            this.Controls.Add(this.cbb_type_jobs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fpn_job_detail);
            this.Controls.Add(this.fpn_jobs);
            this.Name = "MainForm";
            this.Text = "Quản Lý Công Việc";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpn_job_detail;
        private System.Windows.Forms.FlowLayoutPanel fpn_jobs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cbb_type_jobs;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_add_job;
    }
}

