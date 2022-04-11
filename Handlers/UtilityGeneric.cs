using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlers
{
    // where T : struct
    // where T : class
    // where T : IComparable
    // where T : BankAccount
    // where T : BankAccount, new()
    public class UtilityGeneric<T> where T : IComparable
    {
        public T Max(T firstNumber, T secondNumber)
        {
            return firstNumber.CompareTo(secondNumber) > 0 ? firstNumber : secondNumber;
        }
    }
}
