
namespace Schedule_Job
{
	partial class AddjobDetailFrm
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
            this.txtProgress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOver = new System.Windows.Forms.RadioButton();
            this.rbDrop = new System.Windows.Forms.RadioButton();
            this.rbOnGoing = new System.Windows.Forms.RadioButton();
            this.rbComplete = new System.Windows.Forms.RadioButton();
            this.cbbPriority = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDesciption = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstimatedTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtActualTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProgress
            // 
            this.txtProgress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProgress.DefaultText = "";
            this.txtProgress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProgress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProgress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProgress.DisabledState.Parent = this.txtProgress;
            this.txtProgress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProgress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProgress.FocusedState.Parent = this.txtProgress;
            this.txtProgress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProgress.ForeColor = System.Drawing.Color.Black;
            this.txtProgress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProgress.HoverState.Parent = this.txtProgress;
            this.txtProgress.Location = new System.Drawing.Point(49, 368);
            this.txtProgress.Margin = new System.Windows.Forms.Padding(4);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.PasswordChar = '\0';
            this.txtProgress.PlaceholderText = "";
            this.txtProgress.SelectedText = "";
            this.txtProgress.ShadowDecoration.Parent = this.txtProgress;
            this.txtProgress.Size = new System.Drawing.Size(276, 44);
            this.txtProgress.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 438);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 59;
            this.label6.Text = "Mô tả";
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.DisabledState.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(496, 606);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(175, 55);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "HUỶ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.DisabledState.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(309, 606);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(175, 55);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "LƯU";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOver);
            this.groupBox1.Controls.Add(this.rbDrop);
            this.groupBox1.Controls.Add(this.rbOnGoing);
            this.groupBox1.Controls.Add(this.rbComplete);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(383, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(288, 176);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng thái";
            // 
            // rbOver
            // 
            this.rbOver.AutoSize = true;
            this.rbOver.Location = new System.Drawing.Point(19, 135);
            this.rbOver.Margin = new System.Windows.Forms.Padding(4);
            this.rbOver.Name = "rbOver";
            this.rbOver.Size = new System.Drawing.Size(104, 28);
            this.rbOver.TabIndex = 41;
            this.rbOver.Text = "Quá hạn";
            this.rbOver.UseVisualStyleBackColor = true;
            // 
            // rbDrop
            // 
            this.rbDrop.AutoSize = true;
            this.rbDrop.Location = new System.Drawing.Point(19, 101);
            this.rbDrop.Margin = new System.Windows.Forms.Padding(4);
            this.rbDrop.Name = "rbDrop";
            this.rbDrop.Size = new System.Drawing.Size(118, 28);
            this.rbDrop.TabIndex = 40;
            this.rbDrop.Text = "Tạm dừng";
            this.rbDrop.UseVisualStyleBackColor = true;
            // 
            // rbOnGoing
            // 
            this.rbOnGoing.AutoSize = true;
            this.rbOnGoing.Checked = true;
            this.rbOnGoing.Location = new System.Drawing.Point(19, 66);
            this.rbOnGoing.Margin = new System.Windows.Forms.Padding(4);
            this.rbOnGoing.Name = "rbOnGoing";
            this.rbOnGoing.Size = new System.Drawing.Size(159, 28);
            this.rbOnGoing.TabIndex = 39;
            this.rbOnGoing.TabStop = true;
            this.rbOnGoing.Text = "Đang tiến hành";
            this.rbOnGoing.UseVisualStyleBackColor = true;
            // 
            // rbComplete
            // 
            this.rbComplete.AutoSize = true;
            this.rbComplete.Location = new System.Drawing.Point(19, 36);
            this.rbComplete.Margin = new System.Windows.Forms.Padding(4);
            this.rbComplete.Name = "rbComplete";
            this.rbComplete.Size = new System.Drawing.Size(129, 28);
            this.rbComplete.TabIndex = 38;
            this.rbComplete.Text = "Hoàn thành";
            this.rbComplete.UseVisualStyleBackColor = true;
            // 
            // cbbPriority
            // 
            this.cbbPriority.BackColor = System.Drawing.Color.Transparent;
            this.cbbPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPriority.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPriority.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPriority.FocusedState.Parent = this.cbbPriority;
            this.cbbPriority.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbPriority.ForeColor = System.Drawing.Color.Black;
            this.cbbPriority.HoverState.Parent = this.cbbPriority;
            this.cbbPriority.ItemHeight = 30;
            this.cbbPriority.Items.AddRange(new object[] {
            "Không quan trọng",
            "Quan trọng"});
            this.cbbPriority.ItemsAppearance.Parent = this.cbbPriority;
            this.cbbPriority.Location = new System.Drawing.Point(383, 368);
            this.cbbPriority.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPriority.Name = "cbbPriority";
            this.cbbPriority.ShadowDecoration.Parent = this.cbbPriority;
            this.cbbPriority.Size = new System.Drawing.Size(287, 36);
            this.cbbPriority.StartIndex = 0;
            this.cbbPriority.TabIndex = 53;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(49, 79);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(621, 44);
            this.txtName.TabIndex = 51;
            // 
            // txtDesciption
            // 
            this.txtDesciption.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesciption.DefaultText = "";
            this.txtDesciption.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDesciption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDesciption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesciption.DisabledState.Parent = this.txtDesciption;
            this.txtDesciption.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesciption.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDesciption.FocusedState.Parent = this.txtDesciption;
            this.txtDesciption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDesciption.ForeColor = System.Drawing.Color.Black;
            this.txtDesciption.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDesciption.HoverState.Parent = this.txtDesciption;
            this.txtDesciption.Location = new System.Drawing.Point(47, 466);
            this.txtDesciption.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesciption.Multiline = true;
            this.txtDesciption.Name = "txtDesciption";
            this.txtDesciption.PasswordChar = '\0';
            this.txtDesciption.PlaceholderText = "";
            this.txtDesciption.SelectedText = "";
            this.txtDesciption.ShadowDecoration.Parent = this.txtDesciption;
            this.txtDesciption.Size = new System.Drawing.Size(624, 118);
            this.txtDesciption.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Tiến độ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Mức độ ưu tiên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Thời gian hoàn thành thực tế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Thời gian hoàn thành dự kiến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tên chi tiết công việc:";
            // 
            // txtEstimatedTime
            // 
            this.txtEstimatedTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstimatedTime.DefaultText = "";
            this.txtEstimatedTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEstimatedTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEstimatedTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstimatedTime.DisabledState.Parent = this.txtEstimatedTime;
            this.txtEstimatedTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstimatedTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstimatedTime.FocusedState.Parent = this.txtEstimatedTime;
            this.txtEstimatedTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEstimatedTime.ForeColor = System.Drawing.Color.Black;
            this.txtEstimatedTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstimatedTime.HoverState.Parent = this.txtEstimatedTime;
            this.txtEstimatedTime.Location = new System.Drawing.Point(49, 174);
            this.txtEstimatedTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstimatedTime.Name = "txtEstimatedTime";
            this.txtEstimatedTime.PasswordChar = '\0';
            this.txtEstimatedTime.PlaceholderText = "";
            this.txtEstimatedTime.SelectedText = "";
            this.txtEstimatedTime.ShadowDecoration.Parent = this.txtEstimatedTime;
            this.txtEstimatedTime.Size = new System.Drawing.Size(145, 44);
            this.txtEstimatedTime.TabIndex = 61;
            // 
            // txtActualTime
            // 
            this.txtActualTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActualTime.DefaultText = "";
            this.txtActualTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtActualTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtActualTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActualTime.DisabledState.Parent = this.txtActualTime;
            this.txtActualTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActualTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualTime.FocusedState.Parent = this.txtActualTime;
            this.txtActualTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtActualTime.ForeColor = System.Drawing.Color.Black;
            this.txtActualTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualTime.HoverState.Parent = this.txtActualTime;
            this.txtActualTime.Location = new System.Drawing.Point(47, 267);
            this.txtActualTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtActualTime.Name = "txtActualTime";
            this.txtActualTime.PasswordChar = '\0';
            this.txtActualTime.PlaceholderText = "";
            this.txtActualTime.SelectedText = "";
            this.txtActualTime.ShadowDecoration.Parent = this.txtActualTime;
            this.txtActualTime.Size = new System.Drawing.Size(148, 44);
            this.txtActualTime.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(203, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Phút";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(203, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Phút";
            // 
            // AddjobDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 705);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtActualTime);
            this.Controls.Add(this.txtEstimatedTime);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbPriority);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDesciption);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddjobDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddjobDetailFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2TextBox txtProgress;
		private System.Windows.Forms.Label label6;
		private Guna.UI2.WinForms.Guna2Button btnCancel;
		private Guna.UI2.WinForms.Guna2Button btnSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private Guna.UI2.WinForms.Guna2ComboBox cbbPriority;
		private Guna.UI2.WinForms.Guna2TextBox txtName;
		private Guna.UI2.WinForms.Guna2TextBox txtDesciption;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2TextBox txtEstimatedTime;
		private Guna.UI2.WinForms.Guna2TextBox txtActualTime;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RadioButton rbOver;
		private System.Windows.Forms.RadioButton rbDrop;
		private System.Windows.Forms.RadioButton rbOnGoing;
		private System.Windows.Forms.RadioButton rbComplete;
	}
}