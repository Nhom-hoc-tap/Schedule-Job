using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class JobDetailBL
    {
        private static readonly JobDetailDA jobDetailDA = JobDetailDA.Instance;

        private static JobDetailBL instance;

        private JobDetailBL()
        {

        }

        public static JobDetailBL Instance
        {
            get
            {
                instance = instance ?? new JobDetailBL();
                return instance;
            }
        }

        public JobDetail GetById(int id)
        {
            return jobDetailDA.GetById(id);
        }

        public List<JobDetail> GetByJobId(int jobId)
        {
            return jobDetailDA.GetByJobId(jobId);
        }

        public bool Insert(JobDetail jobDetail)
        {
            return jobDetailDA.Insert(jobDetail);
        }

        public bool Update(JobDetail jobDetail)
        {
            return jobDetailDA.Update(jobDetail);
        }

        public bool Delete(JobDetail jobDetail)
        {
            return jobDetailDA.Delete(jobDetail);
        }
    }
}
