using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Ultilities
    {
        private static string StrName = "ConnectionStringName";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings[StrName].ConnectionString;
        //---All
        public static string GetAllByTableName = "GetALl";
        //---Job
        public static string Job_GetByAccount = "GetJobByAccountName";
        //---JobDetail
        public static string JobDetail_GetByJob = "GetJobDetailByJobId";
        //---TypeOfJob
        public static string TypeOfJob_GetByAccountName = "GetTypeOfJobByAccountName";
        //---Account

        //public static string ...
    }
}
