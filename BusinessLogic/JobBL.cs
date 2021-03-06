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
        public void SetStatus(int id, int status)
        {
            jobDA.SetStatus(id, status);
        }
        public Job GetById(int id)
        {
            return jobDA.GetById(id);
        }

        public void CheckProgress(int id)
        {
            jobDA.CheckProgress(id);
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

        public bool Delete(int jobId)
        {
            return jobDA.Delete(jobId);
        }
    }
}
