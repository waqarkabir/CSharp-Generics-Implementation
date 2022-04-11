using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountTransaction
    {
        public AccountTransaction(
            decimal amount, 
            DateTime created, 
            TransactionType transactionType)
        {
            Amount = amount;
            Created = created;
            TransactionType = transactionType;
        }

        public DateTime Created { get; }
        public decimal Amount { get; }
        public TransactionType TransactionType { get; }
    }

    public enum TransactionType
    {
        WithDraw = 1,
        PayIn
    }
}
