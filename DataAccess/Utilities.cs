using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Utilities
    {
        private static readonly string stringName = "ConnectionStringName";

        public static string ConnectionString => ConfigurationManager.ConnectionStrings[stringName].ConnectionString;

        //---All
        public static string GetAllByTableName => "GetALl";

        //---Job
        public static string Job_GetByAccount => "GetJobByAccountName";

        //---JobDetail
        public static string JobDetail_GetByJob => "GetJobDetailByJobId";

        //---TypeOfJob
        public static string TypeOfJob_GetByAccountName => "GetTypeOfJobByAccountName";

        //---Account
        public static string Account_Insert => "TaiKhoan_Insert";

        public static string Account_Login => "DangNhap";

        public static string Account_HasAccount => "HasAccount";

        //public static string ...
    }
}
