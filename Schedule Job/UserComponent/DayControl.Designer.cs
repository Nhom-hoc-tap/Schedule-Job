
namespace Schedule_Job.UserComponent
{
    partial class DayControl
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
            this.lbl_day = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbl_day
            // 
            this.lbl_day.Location = new System.Drawing.Point(2, 2);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(37, 18);
            this.lbl_day.TabIndex = 0;
            this.lbl_day.Text = "00";
            // 
            // DayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_day);
            this.Name = "DayControl";
            this.Size = new System.Drawing.Size(42, 44);
            this.Load += new System.EventHandler(this.DayControl_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label lbl_day;
    }
}
