using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class JobDetailDA
    {
        private static JobDetailDA instance;

        private JobDetailDA()
        {

        }

        public static JobDetailDA Instance
        {
            get
            {
                instance = instance ?? new JobDetailDA();
                return instance;
            }
        }

        public void SetStatus(int id, int status)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.JobDetail_SetToDrop;
            command.Parameters.Add("@JobDetailId", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Status", SqlDbType.Int).Value = status;
            command.ExecuteNonQuery();

            sqlConn.Close();
        }

        public JobDetail GetById(int id)
        {
            SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = id
            };
            DataTable table = SqlHelper.Instance.ExecuteReader(Utilities.JobDetail_GetById, idParam);
            DataRow row = table.Rows[0];
            return new JobDetail()
            {
                Id = (int)row["ID"],
                JobId = (int)row["ID_CongViec"],
                Name = row["TenChiTietCV"].ToString(),
                Status = (int)row["TrangThai"],
                EstimateTime = (int)row["ThoiDuKien"],
                ActualTime = (int)row["ThoiThucTe"],
                Priority = (int)row["MucDoUuTien"],
                Description = row["MoTa"].ToString(),
                Progress = (int)row["TienDo"]
            };
        }

        public List<JobDetail> GetByJobId(int jobId)
        {
            List<JobDetail> jobDetails = new List<JobDetail>();
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.JobDetail_GetByJob;
            command.Parameters.Add("@JobId", SqlDbType.Int).Value = jobId;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                JobDetail jobDetail = new JobDetail();

                jobDetail.Id = Convert.ToInt32(reader["ID"]);
                jobDetail.Name = reader["TenChiTietCV"].ToString();
                jobDetail.Description = reader["MoTa"].ToString();
                jobDetail.ActualTime = int.Parse(reader["ThoiThucTe"].ToString());
                jobDetail.EstimateTime = int.Parse(reader["ThoiDuKien"].ToString());
                jobDetail.Priority = int.Parse(reader["MucdoUuTien"].ToString());
                jobDetail.JobId = int.Parse(reader["ID_CongViec"].ToString());
                jobDetail.Progress = int.Parse(reader["TienDo"].ToString());
                jobDetail.Status = int.Parse(reader["TrangThai"].ToString());
                jobDetails.Add(jobDetail);
            }
            sqlConn.Close();
            return jobDetails;
        }

        public bool Insert(JobDetail jobDetail)
        {
            SqlParameter id = new SqlParameter("@id", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            SqlParameter jobId = new SqlParameter("@idCongViec", SqlDbType.Int)
            {
                Value = jobDetail.JobId
            };

            SqlParameter name = new SqlParameter("@ten", SqlDbType.NVarChar, 1000)
            {
                Value = jobDetail.Name
            };

            SqlParameter estimateTime = new SqlParameter("@duKien", SqlDbType.Int)
            {
                Value = jobDetail.EstimateTime
            };

            SqlParameter actualTime = new SqlParameter("@thucTe", SqlDbType.Int)
            {
                Value = jobDetail.ActualTime
            };

            SqlParameter priority = new SqlParameter("@doUuTien", SqlDbType.TinyInt)
            {
                Value = jobDetail.Priority
            };

            SqlParameter progress = new SqlParameter("@tienDo", SqlDbType.Int)
            {
                Value = jobDetail.Progress
            };

            SqlParameter status = new SqlParameter("@trangThai", SqlDbType.Int)
            {
                Value = jobDetail.Status
            };

            SqlParameter description = new SqlParameter("@moTa", SqlDbType.NVarChar, 1000)
            {
                Value = jobDetail.Description
            };

            int result = SqlHelper.Instance.ExecuteNonQuery(Utilities.JobDetail_Insert, id, jobId, name, estimateTime, actualTime, priority, progress, status, description);
            return result > 0;
        }

        public bool Update(JobDetail jobDetail)
        {
            SqlParameter id = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = jobDetail.Id
            };

            SqlParameter jobId = new SqlParameter("@idCongViec", SqlDbType.Int)
            {
                Value = jobDetail.JobId
            };

            SqlParameter name = new SqlParameter("@ten", SqlDbType.NVarChar, 1000)
            {
                Value = jobDetail.Name
            };

            SqlParameter estimateTime = new SqlParameter("@duKien", SqlDbType.Int)
            {
                Value = jobDetail.EstimateTime
            };

            SqlParameter actualTime = new SqlParameter("@thucTe", SqlDbType.Int)
            {
                Value = jobDetail.ActualTime
            };

            SqlParameter priority = new SqlParameter("@doUuTien", SqlDbType.TinyInt)
            {
                Value = jobDetail.Priority
            };

            SqlParameter progress = new SqlParameter("@tienDo", SqlDbType.Int)
            {
                Value = jobDetail.Progress
            };

            SqlParameter status = new SqlParameter("@trangThai", SqlDbType.Int)
            {
                Value = jobDetail.Status
            };

            SqlParameter description = new SqlParameter("@moTa", SqlDbType.NVarChar, 1000)
            {
                Value = jobDetail.Description
            };

            int result = SqlHelper.Instance.ExecuteNonQuery(Utilities.JobDetail_Update, id, jobId, name, estimateTime, actualTime, priority, progress, status, description);
            return result > 0;
        }

        public bool Delete(JobDetail jobDetail)
        {
            SqlParameter id = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = jobDetail.Id
            };

            int result = SqlHelper.Instance.ExecuteNonQuery(Utilities.JobDetail_Delete, id);
            return result > 0;
        }
    }
}
