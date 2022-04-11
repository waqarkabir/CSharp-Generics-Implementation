namespace Models
{
    public abstract class BankAccount : ITransferBankAccount, IComparable, IComparable<BankAccount>
    {
        private static int index = 1000;
        public static int Total = 0;
        public BankAccount()
        {
            Code = index.ToString();
            Created = DateTime.Now;
            AccountStatus = AccountStatus.Active;
            
            index = index + 1;
            Total = Total + 1;
        }

        public BankAccount(AccountType accountType, decimal openingBalance) : this()
        {
            AccountType = accountType;
            this.openingBalance = openingBalance;

            AccountTransactions = new List<AccountTransaction>();
        }

        private decimal openingBalance;

        // data variables
        // code
        public string Code { get; }

        // title
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        // craeted
        public DateTime Created { get; }

        // status
        public AccountStatus AccountStatus { get; private set; }

        // account type
        public AccountType AccountType { get; }

        // balance
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        // methods
        // with draw
        public virtual bool WithDraw(decimal amount)
        {
            if(amount > Balance)
            {
                return false;
            }

            Balance -= amount;

            AccountTransactions.Add(new AccountTransaction
            (
                amount: amount,
                created: DateTime.Now,
                transactionType: TransactionType.WithDraw
            ));

            return true;
        }

        // pay in
        public virtual bool PayIn(decimal amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            Balance += amount;

            AccountTransactions.Add(new AccountTransaction
            (
                amount: amount,
                created: DateTime.Now,
                transactionType: TransactionType.PayIn
            ));
            return true;
        }

        public override string ToString()
        {
            return $"Title: {Title} " +
                $" Account Code: {Code} " +
                $"Created On: {Created.ToString("dd-MMM-yyyy hh:mm:ss")} " +
                $"Type: {AccountType} " +
                $"Status: {AccountStatus} " +
                $"Balance: {Balance}";
        }


        public virtual bool Transfer(BankAccount bankAccount, decimal amount)
        {
            //TODO:How many Bank account objects ???
            if (!WithDraw(amount))
            {
                return false;
            }

            if (!bankAccount.PayIn(amount))
            {
                return PayIn(amount);
            }

            return true;
        }

        public int CompareTo(object? obj)
        {
            var temp = obj as BankAccount;
            if (temp == null) throw new ArgumentNullException(nameof(obj));

            return string.Compare(Code, temp.Code, true);
        }

        public int CompareTo(BankAccount? other)
        {
            if(other == null) throw new ArgumentNullException(nameof(other));
            return string.Compare(Code, other.Code, true);
        }

        private List<AccountTransaction> AccountTransactions { get; set; }

        public IEnumerable<AccountTransaction> GetAccountTransactions()
        {
            return AccountTransactions;
        }
    }

    public enum AccountStatus
    {
        Active = 1,
        Passive
    }

    public enum AccountType
    {
        Saving = 1,
        Current
    }
}