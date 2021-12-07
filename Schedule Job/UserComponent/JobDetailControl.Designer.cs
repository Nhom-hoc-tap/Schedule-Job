
namespace Schedule_Job.UserComponent
{
    partial class JobDetailControl
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
            this.components = new System.ComponentModel.Container();
            this.lbl_name = new System.Windows.Forms.Label();
            this.prg_Progress = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_estimate_time = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pb_priority = new System.Windows.Forms.PictureBox();
            this.lbl_actual_time = new System.Windows.Forms.Label();
            this.lbl_progress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_priority)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(88, 10);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(497, 26);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Job Detail Name";
            // 
            // prg_Progress
            // 
            this.prg_Progress.Location = new System.Drawing.Point(88, 84);
            this.prg_Progress.Name = "prg_Progress";
            this.prg_Progress.Size = new System.Drawing.Size(497, 15);
            this.prg_Progress.TabIndex = 7;
            this.prg_Progress.Value = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thời gian dự kiến :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thời gian thực tế";
            // 
            // lbl_estimate_time
            // 
            this.lbl_estimate_time.AutoSize = true;
            this.lbl_estimate_time.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_estimate_time.Location = new System.Drawing.Point(497, 38);
            this.lbl_estimate_time.Name = "lbl_estimate_time";
            this.lbl_estimate_time.Size = new System.Drawing.Size(44, 17);
            this.lbl_estimate_time.TabIndex = 9;
            this.lbl_estimate_time.Text = "Value";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(359, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 30);
            this.label6.TabIndex = 11;
            // 
            // lbl_description
            // 
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(89, 38);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(271, 34);
            this.lbl_description.TabIndex = 12;
            this.lbl_description.Text = "Job Detail Description";
            // 
            // pb_priority
            // 
            this.pb_priority.Image = global::Schedule_Job.Properties.Resources.icons8_star_filled;
            this.pb_priority.Location = new System.Drawing.Point(12, 10);
            this.pb_priority.Name = "pb_priority";
            this.pb_priority.Size = new System.Drawing.Size(50, 50);
            this.pb_priority.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_priority.TabIndex = 5;
            this.pb_priority.TabStop = false;
            // 
            // lbl_actual_time
            // 
            this.lbl_actual_time.AutoSize = true;
            this.lbl_actual_time.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_actual_time.Location = new System.Drawing.Point(497, 55);
            this.lbl_actual_time.Name = "lbl_actual_time";
            this.lbl_actual_time.Size = new System.Drawing.Size(44, 17);
            this.lbl_actual_time.TabIndex = 9;
            this.lbl_actual_time.Text = "Value";
            // 
            // lbl_progress
            // 
            this.lbl_progress.Location = new System.Drawing.Point(4, 81);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(78, 23);
            this.lbl_progress.TabIndex = 13;
            this.lbl_progress.Text = "label1";
            this.lbl_progress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JobDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_progress);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_actual_time);
            this.Controls.Add(this.lbl_estimate_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prg_Progress);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pb_priority);
            this.Name = "JobDetailControl";
            this.Size = new System.Drawing.Size(612, 110);
            this.Load += new System.EventHandler(this.JobDetailControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_priority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_priority;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ProgressBar prg_Progress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_estimate_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_actual_time;
        private System.Windows.Forms.Label lbl_progress;
    }
}
