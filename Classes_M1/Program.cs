// See https://aka.ms/new-console-template for more information
using Classes_M1;

// initialize local variables
string firstName = "Tim";
 string lastName = "Shao";

// updated objects
firstName = "Sandy";
lastName = "Shao";

//BankCustomer: Create profile for customer
BankCustomer customer3 = new BankCustomer(firstName,lastName);

// display the public data fields for each object
Console.WriteLine($"BankCustomer 3: {customer3.FirstName} {customer3.LastName} {customer3.CustomerId}");

// BankAccount: Create account for customer
BankAccount account3 = new BankAccount(customer3.CustomerId, 2500, "Checking");

// displaly the public data field
 Console.WriteLine($"Account 3: Account # {account3.AccountNumber}, type {account3.AccountType}, balance {account3.Balance}, rate {BankAccount.InterestRate}, customer ID {account3.CustomerId}");