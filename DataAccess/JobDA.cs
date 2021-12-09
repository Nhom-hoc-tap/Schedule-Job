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
        private static JobDA instance;

        private JobDA()
        {

        }

        public static JobDA Instance
        {
            get
            {
                instance = instance ?? new JobDA();
                return instance;
            }
        }

        public List<Job> GetByAccount(string accountName)
        {
            List<Job> jobs = new List<Job>();
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Job_GetByAccount;
            command.Parameters.Add("@AccountName", SqlDbType.NVarChar, 200).Value = accountName;
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
                //job.UserName = reader["TenDangNhap"].ToString();
                jobs.Add(job);
            }
            sqlConn.Close();
            return jobs;
        }

        public bool Insert(Job job)
        {
            SqlParameter id = new SqlParameter("@id", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            SqlParameter name = new SqlParameter("@tenCongViec", SqlDbType.NVarChar, 1000)
            {
                Value = job.Name
            };

            SqlParameter start = new SqlParameter("@batDau", SqlDbType.SmallDateTime)
            {
                Value = job.StartTime
            };

            SqlParameter end = new SqlParameter("@ketThuc", SqlDbType.SmallDateTime)
            {
                Value = job.EndTime
            };
            SqlParameter priority = new SqlParameter("@doUuTien", SqlDbType.TinyInt)
            {
                Value = job.Priority
            };

            SqlParameter progress = new SqlParameter("@tienDo", SqlDbType.TinyInt)
            {
                Value = job.Progress
            };

            SqlParameter typeId = new SqlParameter("@idLoaiCV", SqlDbType.Int)
            {
                Value = job.TypeOfJobId
            };

            SqlParameter status = new SqlParameter("@trangThai", SqlDbType.Int)
            {
                Value = job.Status
            };

            SqlParameter description = new SqlParameter("@moTa", SqlDbType.NVarChar, 1000)
            {
                Value = job.Description
            };

            int result = SqlHelper.Instance.ExecuteNonQuery(Utilities.Job_Insert, id, name, start, end, priority, progress, typeId, status, description);
            return result > 0;
        }

        public bool Update(Job job)
        {
            SqlParameter id = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = job.Id
            };

            SqlParameter name = new SqlParameter("@tenCongViec", SqlDbType.NVarChar, 1000)
            {
                Value = job.Name
            };

            SqlParameter start = new SqlParameter("@batDau", SqlDbType.SmallDateTime)
            {
                Value = job.StartTime
            };

            SqlParameter end = new SqlParameter("@ketThuc", SqlDbType.SmallDateTime)
            {
                Value = job.EndTime
            };
            SqlParameter priority = new SqlParameter("@doUuTien", SqlDbType.TinyInt)
            {
                Value = job.Priority
            };

            SqlParameter progress = new SqlParameter("@tienDo", SqlDbType.TinyInt)
            {
                Value = job.Progress
            };

            SqlParameter typeId = new SqlParameter("@idLoaiCV", SqlDbType.Int)
            {
                Value = job.TypeOfJobId
            };

            SqlParameter status = new SqlParameter("@trangThai", SqlDbType.Int)
            {
                Value = job.Status
            };

            SqlParameter description = new SqlParameter("@moTa", SqlDbType.NVarChar, 1000)
            {
                Value = job.Description
            };

            int result = SqlHelper.Instance.ExecuteNonQuery(Utilities.Job_Update, id, name, start, end, priority, progress, typeId, status, description);
            return result > 0;
        }

        public bool Delete(Job job)
        {
            SqlParameter id = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = job.Id
            };

            int result = SqlHelper.Instance.ExecuteNonQuery(Utilities.Job_Delete, id);
            return result > 0;
        }
    }
}
