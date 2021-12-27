using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class SqlHelper
    {
        private static SqlHelper instance;

        private SqlHelper()
        {

        }

        public static SqlHelper Instance
        {
            get
            {
                instance = instance ?? new SqlHelper();
                return instance;
            }
        }

        public DataTable ExecuteReader(string query, params SqlParameter[] parameters)
        {
            DataTable data = new DataTable();
            using (var conn = new SqlConnection(Utilities.ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);

                conn.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            int data = 0;
            using (var conn = new SqlConnection(Utilities.ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                data = cmd.ExecuteNonQuery();

                conn.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            object data = null;
            using (var conn = new SqlConnection(Utilities.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                data = cmd.ExecuteScalar();

                conn.Close();
            }
            return data;
        }
    }
}
