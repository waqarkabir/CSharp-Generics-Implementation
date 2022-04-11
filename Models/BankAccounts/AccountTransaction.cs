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
        public decimal Tax { get; }

        public DateTime Created { get; }
        public decimal Amount { get; }
        public TransactionType TransactionType { get; }

        public static void TransferSuccessMessage(BankAccount? senderBankAccount,
               BankAccount? receiverBankAccount, decimal amount)
        {
            Console.WriteLine($"Amount of {amount} is transfered from Bank Account: {senderBankAccount.Code} to {receiverBankAccount.Code}");
            Console.WriteLine($"Your current balance is: {senderBankAccount.Balance}");
            Console.WriteLine("Press any key for main menu");
            Console.ReadKey();
        }

        public static void TransferFailureMessage()
        {
            Console.WriteLine($"Amount cannot be transferred.");
            Console.WriteLine("Press any key for main menu");
            Console.ReadKey();
        }
    }

    public enum TransactionType
    {
        WithDraw = 1,
        PayIn
    }
}
