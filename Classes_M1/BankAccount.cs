// tutorial - Create a class named BankAccount that implements private, public, and static members

using System;
namespace Classes_M1;

public class BankAccount
{
    // initialize public fields
    public int AccountNumber; // A public field that stores the account number
    public double Balance; // A public field that stores the account balance

    public static double InterestRate; // A static field that stores the interest rate

    public string AccountType = ""; // A public field that stores the account type

    public readonly string CustomerId; // A public read-only field that stores the customer ID for the account
    private static int s_nextAccountNumber; // A static field that stores the next account number

    // a static constructor that initializes the s_nextAccountNumber and InterestRate fields
    static BankAccount()
    {
        Random random = new Random();
        s_nextAccountNumber = random.Next(110000000, 20000000);
        InterestRate = 0;
    }
    
    public BankAccount(string customerId, double balance, string accountType)
    {
        this.AccountNumber = s_nextAccountNumber++;
        this.CustomerId = customerId;
        this.Balance = balance;
        this.AccountType = accountType;
    }

}
