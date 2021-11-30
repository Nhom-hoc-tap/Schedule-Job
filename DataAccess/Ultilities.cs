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
        public static string Job_GetAll = "select * from Job";
        //---JobDetail
        //---TypeOfJob
        //---Account

        //public static string ...
    }
}
