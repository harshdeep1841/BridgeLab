public class BankAccount
{
    public long AccountNumber { get; }
    public string AccountHolder { get; }

    public long Balance { get; private set; }

    public BankAccount(long accountNumber, string accountHolder)
        : this(accountNumber, accountHolder, 0)
    {
    }

    public BankAccount(long accountNumber, string accountHolder, long balance)
    {
        if (balance < 0)
            throw new ArgumentException("Balance cannot be negative.");

        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public void Deposit(long amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Amount must be positive.");

        Balance += amount;
    }

    public virtual bool Withdraw(long amount)
    {
        if (amount <= 0 || amount > Balance)
            return false;

        Balance -= amount;
        return true;
    }
}

public class SavingAccount : BankAccount
{
    public SavingAccount(long accountNumber, string accountHolder)
        : base(accountNumber, accountHolder)
    {
    }
}