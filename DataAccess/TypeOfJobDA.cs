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
                typeOfJob.User = reader["TenDangNhap"].ToString();
                
                typeOfJobs.Add(typeOfJob);
            }
            sqlConn.Close();
            return typeOfJobs;
        }
    }
}
