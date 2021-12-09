using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class JobDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int EstimateTime { get; set; }
        public int ActualTime { get; set; }
        public int Priority { get; set; }

        private int status;
        //0 on going, 1 complete, -1 over, 2 drop
        public int Status {
            get {return status; }
            set
            {
                if (Progress == 100)
                    status = 1;
                else if (Progress < 100)
                    status = 0;
                else
                {
                    status = value;
                }
            }
        }
        public int JobId { get; set; }
        public int Progress { get; set; }
    }
}
