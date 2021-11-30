using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class JobDA
    {
        public List<Job> GetAll()
        {
            List<Job> jobs = new List<Job>();
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.GetAllByTableName;
            command.Parameters.Add("@TableName", SqlDbType.NVarChar, 200).Value = "CongViec";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Job job = new Job();

                job.Id = Convert.ToInt32(reader["ID"]);
                job.Name = reader["TenCongViec"].ToString();
                job.Description = reader["MoTa"].ToString();
                job.StartTime = DateTime.Parse(reader["ThoiGianBatDau"].ToString());
                job.EndTime = DateTime.Parse(reader["ThoiGianKetThuc"].ToString());
                job.Priority = Convert.ToInt32(reader["MucdoUuTien"]);
                job.Progress = Convert.ToInt32(reader["TienDo"]);
                job.Status = Convert.ToInt32(reader["TrangThai"]);
                job.TypeOfJobId = Convert.ToInt32(reader["ID_LoaiCV"]);
                job.UserName = reader["TenDangNhap"].ToString();
                jobs.Add(job);
            }
            sqlConn.Close();
            return jobs;
        }
    }
}
