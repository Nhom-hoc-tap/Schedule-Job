using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class JobBL
    {
        private static readonly JobDA jobDA = JobDA.Instance;

        private static JobBL instance;

        private JobBL()
        {

        }

        public static JobBL Instance
        {
            get
            {
                instance = instance ?? new JobBL();
                return instance;
            }
        }

        public List<Job> GetByAccount(string accountName)
        {
            return jobDA.GetByAccount(accountName);
        }

        public bool Insert(Job job)
        {
            return jobDA.Insert(job);
        }

        public bool Update(Job job)
        {
            return jobDA.Update(job);
        }

        public bool Delete(Job job)
        {
            return jobDA.Delete(job);
        }
    }
}
