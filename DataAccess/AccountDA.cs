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

        public bool HasAccount(string userName)
        {
            SqlParameter userNameParam = new SqlParameter("@TenDangNhap", SqlDbType.NVarChar, 255)
            {
                Value = userName
            };

            DataTable dataTable = SqlHelper.Instance.ExecuteReader(Utilities.Account_HasAccount, userNameParam);
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

            int result = SqlHelper.Instance.ExecuteNonQuery(Utilities.Account_Insert, userName, password, fullName, gender, birth);
            return result > 0;
        }
    }
}
