using Classes_M1;

string firstName = "Tim";
string lastName = "Shao";

BankCustomer customer1 = new BankCustomer();
BankCustomer customer2 = new BankCustomer(firstName, lastName);

firstName = "Bella";
lastName = "Donna";

BankCustomer customer3 = new BankCustomer(firstName, lastName);

Console.WriteLine($"Bankcustomer1: {customer1.FirstName} {customer1.LastName} {customer1.CustomerId}");
Console.WriteLine($"Bankcustomer2: {customer2.FirstName} {customer2.LastName} {customer2.CustomerId}");
Console.WriteLine($"Bankcustomer3: {customer3.FirstName} {customer3.LastName} {customer3.CustomerId}");

 BankAccount account1 = new BankAccount(customer1.CustomerId);
 BankAccount account2 = new BankAccount(customer2.CustomerId, 1500, "Checking");
 BankAccount account3 = new BankAccount(customer3.CustomerId, 2500, "Checking");

 Console.WriteLine();
 
 Console.WriteLine($"Account 1: Account # {account1.AccountNumber}, type {account1.AccountType}, balance {account1.Balance}, rate {BankAccount.InterestRate}, customer ID {account1.CustomerId}");
 Console.WriteLine($"Account 2: Account # {account2.AccountNumber}, type {account2.AccountType}, balance {account2.Balance}, rate {BankAccount.InterestRate}, customer ID {account2.CustomerId}");
 Console.WriteLine($"Account 3: Account # {account3.AccountNumber}, type {account3.AccountType}, balance {account3.Balance}, rate {BankAccount.InterestRate}, customer ID {account3.CustomerId}");
