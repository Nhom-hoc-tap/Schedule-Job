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
        JobDA jobDA = new JobDA();
        public List<Job> GetAll()
        {
            return jobDA.GetAll();
        }
    }
}
