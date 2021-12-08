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
        private static readonly TypeOfJobDA typeOfJobDA = TypeOfJobDA.Instance;

        private static TypeOfJobBL instance;

        private TypeOfJobBL()
        {

        }

        public static TypeOfJobBL Instance
        {
            get
            {
                instance = instance ?? new TypeOfJobBL();
                return instance;
            }
        }

        public List<TypeOfJob> GetByAccount(string accountName)
        {
            return typeOfJobDA.GetByAccount(accountName);
        }

        public bool Insert(TypeOfJob typeOfJob)
        {
            return typeOfJobDA.Insert(typeOfJob);
        }
    }
}
