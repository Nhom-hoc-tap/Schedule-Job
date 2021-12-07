using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class TypeOfJobBL
    {
        TypeOfJobDA typeOfJobDA = new TypeOfJobDA();
        public List<TypeOfJob> GetByAccount(string accountName)
        {
            return typeOfJobDA.GetByAccount(accountName);
        }
    }
}
