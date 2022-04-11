using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlers.Comparers
{
    public class SeniorityComparer : IComparer<BankAccount>
    {
        public int Compare(BankAccount? x, BankAccount? y)
        {
            if(x == null && y == null) throw new ArgumentNullException(nameof(x));
            return string.Compare(x?.Code, y?.Code, true);
        }
    }
}
