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
        public int Status { get; set; }
        public int JobId { get; set; }
        public int Progress { get; set; }
        
    }
}
