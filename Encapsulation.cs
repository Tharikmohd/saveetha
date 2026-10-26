using System;

class Encapsulation
{
    public static void Main()
    {
        Bank bank = new Bank();
        bank.Deposit = 450;
        Console.WriteLine(bank.Deposit);
        bank.Withdrawan = 9000;
        
        Console.WriteLine(bank.Withdrawan);
    }
}

class Bank
{
    private double balance = 54903.45;

    public double Deposit
    {
        get
        {
            return balance;
        }
        set
        {
            if(value <0 )
            {
                Console.WriteLine("Please enter valid Amount for deposit");
            }
            else
            {
                balance += value;
            }
        }
    }

    public double Withdrawan
    {
        get
        {
            return balance;
        }
        set
        {
            if(value <0)
            {
                Console.WriteLine("Enter Valid amount to withdrawan");
            }
            else if (value >= balance)
            {
                Console.WriteLine("Insufficient Amount");
            }
            else
            {
                balance -= value;
            }
        }
    }
}