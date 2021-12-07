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
        JobDetailDA jobDetailDA = new JobDetailDA();
        public List<JobDetail> GetByJobId(int jobId)
        {
            return jobDetailDA.GetByJobId(jobId);
        }
    }
}
