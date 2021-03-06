using Schedule_Job;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AccountDA
    {
        private static AccountDA instance;

        private AccountDA()
        {

        }

        public static AccountDA Instance
        {
            get
            {
                instance = instance ?? new AccountDA();
                return instance;
            }
        }

        public bool Login(string userName, string password)
        {
            SqlParameter userNameParam = new SqlParameter("@TenDangNhap", SqlDbType.NVarChar, 255)
            {
                Value = userName
            };

            SqlParameter passwordParam = new SqlParameter("@MatKhau", SqlDbType.NVarChar, 1000)
            {
                Value = password
            };

            DataTable dataTable = SqlHelper.Instance.ExecuteReader(Utilities.Account_Login, userNameParam, passwordParam);
            return dataTable.Rows.Count > 0;
        }

        public Account GetAccount(string userName)
        {
            SqlParameter userNameParam = new SqlParameter("@TenDangNhap", SqlDbType.NVarChar, 255)
            {
                Value = userName
            };

            DataTable dataTable = SqlHelper.Instance.ExecuteReader(Utilities.Account_GetAccount, userNameParam);
            DataRow row = dataTable.Rows[0];
            return new Account()
            {
                UserName = row["TenDangNhap"].ToString(),
                Password = row["MatKhau"].ToString(),
                FullName = row["HovaTen"].ToString(),
                Gender = row["GioiTinh"].ToString() == "1",
                Birth = DateTime.Parse(row["NgaySinh"].ToString())
            };
        }

        public bool HasAccount(string userName)
        {
            SqlParameter userNameParam = new SqlParameter("@TenDangNhap", SqlDbType.NVarChar, 255)
            {
                Value = userName
            };

            DataTable dataTable = SqlHelper.Instance.ExecuteReader(Utilities.Account_GetAccount, userNameParam);
            return dataTable.Rows.Count > 0;
        }

        public bool Insert(Account account)
        {
            SqlParameter userName = new SqlParameter("@TenDangNhap", SqlDbType.NVarChar, 255)
            {
                Value = account.UserName
            };

            SqlParameter password = new SqlParameter("@MatKhau", SqlDbType.NVarChar, 1000)
            {
                Value = account.Password
            };

            SqlParameter fullName = new SqlParameter("@HovaTen", SqlDbType.NVarChar, 1000)
            {
                Value = account.FullName
            };

            SqlParameter gender = new SqlParameter("@GioiTinh", SqlDbType.Bit)
            {
                Value = account.Gender
            };

            SqlParameter birth = new SqlParameter("@NgaySinh", SqlDbType.SmallDateTime)
            {
                Value = account.Birth
            };
            SqlParameter Question = new SqlParameter("@Cauhoi", SqlDbType.NVarChar,255)
            {
                Value = account.Question
            };
            SqlParameter Answer = new SqlParameter("@Cautraloi", SqlDbType.NVarChar, 255)
            {
                Value = account.Answer
            };

            int result = SqlHelper.Instance.ExecuteNonQuery(Utilities.Account_Insert, userName, password, fullName, gender, birth,Question,Answer);
            return result > 0;
        }

        public bool Update(string username,string password)
		{
            string query = string.Format("UPDATE TaiKhoan SET [MatKhau] = N'{1}' where [TenDangNhap] = N'{0}'", username, password);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
		}
    }
}
