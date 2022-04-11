using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlers
{
    public class BankAccountHandler : IBankAccountHandler
    {
        private readonly List<BankAccount> _bankAccounts;
        public BankAccountHandler()
        {
            _bankAccounts = new List<BankAccount>();
        }

        public void Add(BankAccount bankAccount)
        {
            _bankAccounts.Add(bankAccount);
        }

        public BankAccount? GetBankAccount(string Code, bool ignoreCase = false)
        {
            BankAccount bankAccount = null;

            foreach (var item in _bankAccounts)
            {
                if(string.Compare(item.Code, Code, ignoreCase) == 0)
                {
                    bankAccount = item;
                    break;
                }
            }

            return bankAccount;
        }

        public IEnumerable<BankAccount> GetBankAccounts()
        {
            return _bankAccounts;
        }
    }
}
