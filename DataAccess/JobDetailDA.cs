using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class JobDetailDA
    {
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
                jobDetail.Status = int.Parse(reader["TrangThai"].ToString());
                jobDetail.Progress = int.Parse(reader["TienDo"].ToString());
                jobDetails.Add(jobDetail);
            }
            sqlConn.Close();
            return jobDetails;
        }
    }
}
