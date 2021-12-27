using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
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
        public static string Job_GetById => "CongViec_GetById";

        public static string Job_GetByAccount => "GetJobByAccountName";

        public static string Job_Insert => "CongViec_Insert";

        public static string Job_Update => "CongViec_Update";

        public static string Job_Delete => "CongViec_Delete";

        public static string Job_SetToDrop => "SetJobStatus";

        public static string Job_CheckProgress => "CheckJobProgress";

        //---JobDetail
        public static string JobDetail_GetById => "ChiTietCV_GetById";

        public static string JobDetail_GetByJob => "GetJobDetailByJobId";

        public static string JobDetail_Insert => "ChiTietCV_Insert";

        public static string JobDetail_Update => "ChiTietCV_Update";

        public static string JobDetail_Delete => "ChiTietCV_Delete";

        public static string JobDetail_SetToDrop => "SetJobDetailStatus";

        //---TypeOfJob
        public static string TypeOfJob_GetByAccountName => "GetTypeOfJobByAccountName";

        public static string TypeOfJob_Insert => "LoaiCV_Insert";

        //---Account
        public static string Account_Insert => "TaiKhoan_Insert";

        public static string Account_Login => "DangNhap";

        public static string Account_GetAccount => "GetAccountByUserName";

        //public static string ...
    }
}
