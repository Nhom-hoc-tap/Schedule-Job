using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Job
{
	public partial class Password : Form
	{
		DataTable table = new DataTable();
		public Password()
		{
			InitializeComponent();
		}

		private void Password_Load(object sender, EventArgs e)
		{
			LoadMK();
		}

		public void LoadMK()
		{
			string connectionString = "server=DESKTOP-ONTGILH\\SQLEXPRESS; database = ReminderSystem; Integrated Security = true;";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			// tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlConnection.Open();

			sqlCommand.CommandText = "select TenDangNhap,MatKhau from TaiKhoan where CauHoi = N'" + ForgotPassWordForm.Question+ "' and CauTraloi = N'"+ ForgotPassWordForm.Answer+ "'";

			//Tạo đối tượng DataAdapter
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			// tạo datatable để chứa dữ liệu

			da.Fill(table);

			// Hiển thị danh sách món ăn lên form
			dgvPassword.DataSource = table;

			// đóng kết nối và giải phóng bộ nhớ
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}
	}
}
