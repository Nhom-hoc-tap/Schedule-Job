
namespace Schedule_Job
{
	partial class ChangePasswordFrm
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
			this.txtTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mật khẩu";
			// 
			// txtPassword
			// 
			this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPassword.DefaultText = "";
			this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.DisabledState.Parent = this.txtPassword;
			this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPassword.FocusedState.Parent = this.txtPassword;
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtPassword.ForeColor = System.Drawing.Color.Black;
			this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPassword.HoverState.Parent = this.txtPassword;
			this.txtPassword.Location = new System.Drawing.Point(97, 71);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '\0';
			this.txtPassword.PlaceholderText = "";
			this.txtPassword.SelectedText = "";
			this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
			this.txtPassword.Size = new System.Drawing.Size(302, 36);
			this.txtPassword.TabIndex = 1;
			// 
			// btnChangePassword
			// 
			this.btnChangePassword.CheckedState.Parent = this.btnChangePassword;
			this.btnChangePassword.CustomImages.Parent = this.btnChangePassword;
			this.btnChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnChangePassword.DisabledState.Parent = this.btnChangePassword;
			this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.btnChangePassword.ForeColor = System.Drawing.Color.White;
			this.btnChangePassword.HoverState.Parent = this.btnChangePassword;
			this.btnChangePassword.Location = new System.Drawing.Point(405, 71);
			this.btnChangePassword.Name = "btnChangePassword";
			this.btnChangePassword.ShadowDecoration.Parent = this.btnChangePassword;
			this.btnChangePassword.Size = new System.Drawing.Size(125, 36);
			this.btnChangePassword.TabIndex = 2;
			this.btnChangePassword.Text = "Đổi mật khẩu";
			this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
			// 
			// txtTaiKhoan
			// 
			this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTaiKhoan.DefaultText = "";
			this.txtTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTaiKhoan.DisabledState.Parent = this.txtTaiKhoan;
			this.txtTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTaiKhoan.FocusedState.Parent = this.txtTaiKhoan;
			this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtTaiKhoan.ForeColor = System.Drawing.Color.Black;
			this.txtTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTaiKhoan.HoverState.Parent = this.txtTaiKhoan;
			this.txtTaiKhoan.Location = new System.Drawing.Point(97, 18);
			this.txtTaiKhoan.Name = "txtTaiKhoan";
			this.txtTaiKhoan.PasswordChar = '\0';
			this.txtTaiKhoan.PlaceholderText = "";
			this.txtTaiKhoan.SelectedText = "";
			this.txtTaiKhoan.ShadowDecoration.Parent = this.txtTaiKhoan;
			this.txtTaiKhoan.Size = new System.Drawing.Size(302, 36);
			this.txtTaiKhoan.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tài khoản";
			// 
			// ChangePasswordFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 119);
			this.Controls.Add(this.txtTaiKhoan);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnChangePassword);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label1);
			this.Name = "ChangePasswordFrm";
			this.Text = "Đổi mật khẩu";
			this.Load += new System.EventHandler(this.ChangePasswordFrm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2TextBox txtPassword;
		private Guna.UI2.WinForms.Guna2Button btnChangePassword;
		private Guna.UI2.WinForms.Guna2TextBox txtTaiKhoan;
		private System.Windows.Forms.Label label2;
	}
}