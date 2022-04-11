using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlers
{
    public class Utility
    {
        public int Max(int firstNumber, int secondNumber)
        {
            return firstNumber > secondNumber ? firstNumber : secondNumber;
        }

        public decimal Max(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber > secondNumber ? firstNumber : secondNumber;
        }

        public float Max(float firstNumber, float secondNumber)
        {
            return firstNumber > secondNumber ? firstNumber : secondNumber;
        }

        public T Max<T>(T firstNumber, T secondNumber) where T : IComparable
        {
            return firstNumber.CompareTo(secondNumber) > 0 ? firstNumber : secondNumber;
        }
    }
}
