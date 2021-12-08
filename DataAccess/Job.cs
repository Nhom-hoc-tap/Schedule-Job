using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Priority { get; set; }
        public int Progress { get; set; }
        //0 - on going, 1 - complete , -1 over, 2 drop
        private int status;
        public int Status 
        { 
            get { return status; }
            set {
                if (Progress == 100)
                    this.status = 1;
                else if (EndTime < DateTime.Now)
                    this.status = -1;
                else
                    status = value;
            } 
        } 
        public int TypeOfJobId { get; set; }
        //public string UserName { get; set; }
    }
}
