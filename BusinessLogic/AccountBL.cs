using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AccountBL
    {
        private static readonly AccountDA accountDA = AccountDA.Instance;

        private static AccountBL instance;

        private AccountBL()
        {

        }

        public static AccountBL Instance
        {
            get
            {
                instance = instance ?? new AccountBL();
                return instance;
            }
        }

        public bool Login(string userName, string password)
        {
            return accountDA.Login(userName, password);
        }

        public Account GetAccount(string userName)
        {
            return accountDA.GetAccount(userName);
        }

        public bool HasAccount(string userName)
        {
            return accountDA.HasAccount(userName);
        }

        public bool Insert(Account account)
        {
            return accountDA.Insert(account);
        }
    }
}
