﻿
namespace Schedule_Job.UserComponent
{
    partial class JobControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cpb_job_progress = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_finish_time = new System.Windows.Forms.Label();
            this.lbl_start_time = new System.Windows.Forms.Label();
            this.lbl_job_name = new System.Windows.Forms.Label();
            this.lbl_value_time_start = new System.Windows.Forms.Label();
            this.lbl_value_time_finish = new System.Windows.Forms.Label();
            this.pb_priority = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_priority)).BeginInit();
            this.SuspendLayout();
            // 
            // cpb_job_progress
            // 
            this.cpb_job_progress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpb_job_progress.AnimationSpeed = 500;
            this.cpb_job_progress.BackColor = System.Drawing.Color.Transparent;
            this.cpb_job_progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpb_job_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpb_job_progress.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpb_job_progress.InnerMargin = 2;
            this.cpb_job_progress.InnerWidth = -1;
            this.cpb_job_progress.Location = new System.Drawing.Point(349, 10);
            this.cpb_job_progress.MarqueeAnimationSpeed = 2000;
            this.cpb_job_progress.Name = "cpb_job_progress";
            this.cpb_job_progress.OuterColor = System.Drawing.Color.Gray;
            this.cpb_job_progress.OuterMargin = -25;
            this.cpb_job_progress.OuterWidth = 26;
            this.cpb_job_progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpb_job_progress.ProgressWidth = 15;
            this.cpb_job_progress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpb_job_progress.Size = new System.Drawing.Size(120, 110);
            this.cpb_job_progress.StartAngle = 270;
            this.cpb_job_progress.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpb_job_progress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpb_job_progress.SubscriptText = "";
            this.cpb_job_progress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpb_job_progress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpb_job_progress.SuperscriptText = "";
            this.cpb_job_progress.TabIndex = 11;
            this.cpb_job_progress.Text = "68%";
            this.cpb_job_progress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpb_job_progress.Value = 68;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(342, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 116);
            this.label2.TabIndex = 10;
            // 
            // lbl_finish_time
            // 
            this.lbl_finish_time.AutoSize = true;
            this.lbl_finish_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_finish_time.Location = new System.Drawing.Point(87, 86);
            this.lbl_finish_time.Name = "lbl_finish_time";
            this.lbl_finish_time.Size = new System.Drawing.Size(80, 17);
            this.lbl_finish_time.TabIndex = 5;
            this.lbl_finish_time.Text = "Time Finish";
            // 
            // lbl_start_time
            // 
            this.lbl_start_time.AutoSize = true;
            this.lbl_start_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start_time.Location = new System.Drawing.Point(87, 60);
            this.lbl_start_time.Name = "lbl_start_time";
            this.lbl_start_time.Size = new System.Drawing.Size(73, 17);
            this.lbl_start_time.TabIndex = 7;
            this.lbl_start_time.Text = "Time Start";
            // 
            // lbl_job_name
            // 
            this.lbl_job_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_job_name.Location = new System.Drawing.Point(86, 11);
            this.lbl_job_name.Name = "lbl_job_name";
            this.lbl_job_name.Size = new System.Drawing.Size(250, 49);
            this.lbl_job_name.TabIndex = 8;
            this.lbl_job_name.Text = "Job Name";
            // 
            // lbl_value_time_start
            // 
            this.lbl_value_time_start.AutoSize = true;
            this.lbl_value_time_start.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_value_time_start.Location = new System.Drawing.Point(199, 60);
            this.lbl_value_time_start.Name = "lbl_value_time_start";
            this.lbl_value_time_start.Size = new System.Drawing.Size(106, 17);
            this.lbl_value_time_start.TabIndex = 12;
            this.lbl_value_time_start.Text = "Value time start";
            // 
            // lbl_value_time_finish
            // 
            this.lbl_value_time_finish.AutoSize = true;
            this.lbl_value_time_finish.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_value_time_finish.Location = new System.Drawing.Point(199, 86);
            this.lbl_value_time_finish.Name = "lbl_value_time_finish";
            this.lbl_value_time_finish.Size = new System.Drawing.Size(111, 17);
            this.lbl_value_time_finish.TabIndex = 12;
            this.lbl_value_time_finish.Text = "Value time finish";
            // 
            // pb_priority
            // 
            this.pb_priority.Image = global::Schedule_Job.Properties.Resources.icons8_star_20;
            this.pb_priority.Location = new System.Drawing.Point(10, 10);
            this.pb_priority.Name = "pb_priority";
            this.pb_priority.Size = new System.Drawing.Size(50, 50);
            this.pb_priority.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_priority.TabIndex = 4;
            this.pb_priority.TabStop = false;
            // 
            // JobControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_value_time_finish);
            this.Controls.Add(this.lbl_value_time_start);
            this.Controls.Add(this.cpb_job_progress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_finish_time);
            this.Controls.Add(this.lbl_start_time);
            this.Controls.Add(this.lbl_job_name);
            this.Controls.Add(this.pb_priority);
            this.Name = "JobControl2";
            this.Size = new System.Drawing.Size(475, 128);
            ((System.ComponentModel.ISupportInitialize)(this.pb_priority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar cpb_job_progress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_finish_time;
        private System.Windows.Forms.Label lbl_start_time;
        private System.Windows.Forms.Label lbl_job_name;
        private System.Windows.Forms.PictureBox pb_priority;
        private System.Windows.Forms.Label lbl_value_time_start;
        private System.Windows.Forms.Label lbl_value_time_finish;
    }
}
