using System;
namespace Classes_M1;

// Update the constructor to assign constructor parameters to local variables
public class BankCustomer
{
    // Initialize public fields to class definition
    public string FirstName="";
    public string LastName="";
    public readonly string CustomerId; // read-only field
    private static int s_nextCustomerId; // counter is fixed

    static BankCustomer()  // static constructor that initializes unique customerID
    {
        Random random = new Random();
        s_nextCustomerId = random.Next(10000000, 20000000);
    }

    public BankCustomer(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        CustomerId = (s_nextCustomerId++).ToString("D10"); // formats the numeric ID into a 10-digit string
    }
}