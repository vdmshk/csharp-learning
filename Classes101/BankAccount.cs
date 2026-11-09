using System;

namespace Classes_M1;

public class BankAccount
{
    public int AccountNumber;
    public double Balance;
    public static double InterestRate;
    public string AccountType = "Cheking";
    public readonly string CustomerId;
    private static int s_nextAccountNumber;

    static BankAccount()
    {
        Random random = new Random();
        s_nextAccountNumber = random.Next(10000000, 20000000);
        InterestRate = 0;
    }

    public BankAccount(string customerIdNumber)
    {
        this.AccountNumber = s_nextAccountNumber++;
        this.CustomerId = customerIdNumber;
    }

    public BankAccount(string customerIdNumber, double balance, string accountType)
    {
        this.AccountNumber = s_nextAccountNumber++;
        this.CustomerId = customerIdNumber;
        this.Balance = balance;
        this.AccountType = accountType;
    }
}
