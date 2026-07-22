/*
design a banking system - 
1. create an interface IBankAccount having method WithdrawCash().
2. create an abstract class BankAccount implementing the interface.
3. add one common method DisplayBankName in BankAccount which prints "ABC Bank".
4. create a class SavingsAccount inheriting from BankAccount.
5. implement WithdrawCash() in SavingsAccount.
6. in main(), call both methods
*/

using System;

// Step 1: Create an interface
interface IBankAccount
{
    void WithdrawCash();
}

// Step 2: Create an abstract class implementing the interface
abstract class BankAccount : IBankAccount
{
    // Step 3: Common method for all bank accounts
    public void DisplayBankName()
    {
        Console.WriteLine("ABC Bank");
    }

    // Interface method is kept abstract
    public abstract void WithdrawCash();
}

// Step 4: Create SavingsAccount class
class SavingsAccount : BankAccount
{
    // Step 5: Implement WithdrawCash()
    public override void WithdrawCash()
    {
        Console.WriteLine("Cash withdrawn successfully from Savings Account.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 6: Create object
        SavingsAccount account = new SavingsAccount();

        // Call common method
        account.DisplayBankName();

        // Call implemented method
        account.WithdrawCash();
    }
}