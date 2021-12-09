using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TypeOfJobDA
    {
        private static TypeOfJobDA instance;

        private TypeOfJobDA()
        {

        }

        public static TypeOfJobDA Instance
        {
            get
            {
                instance = instance ?? new TypeOfJobDA();
                return instance;
            }
        }

        public List<TypeOfJob> GetByAccount(string accountName)
        {
            List<TypeOfJob> typeOfJobs = new List<TypeOfJob>();
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.TypeOfJob_GetByAccountName;
            command.Parameters.Add("@AccountName", SqlDbType.NVarChar, 200).Value = accountName;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TypeOfJob typeOfJob = new TypeOfJob();

                typeOfJob.Id = Convert.ToInt32(reader["ID"]);
                typeOfJob.Name = reader["TenLoaiCV"].ToString();
                typeOfJob.UserName = reader["TenDangNhap"].ToString();
                typeOfJobs.Add(typeOfJob);
            }
            sqlConn.Close();
            return typeOfJobs;
        }

        public bool Insert(TypeOfJob typeOfJob)
        {
            SqlParameter id = new SqlParameter("@ID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            SqlParameter name = new SqlParameter("@TenLoaiCV", SqlDbType.NVarChar, 1000)
            {
                Value = typeOfJob.Name
            };

            SqlParameter user = new SqlParameter("@TenDangNhap", SqlDbType.NVarChar, 255)
            {
                Value = typeOfJob.UserName
            };

            int result = SqlHelper.Instance.ExecuteNonQuery(Utilities.TypeOfJob_Insert, id, name, user);
            return result > 0;
        }
    }
}
