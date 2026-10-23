using System;

class Ctppoly
{
    public static void Main()
    {
        BankTransfer bankTransfer = new BankTransfer();
         bankTransfer.Payment(34555);
         bankTransfer.Payment(45000, "Txn00987");
         bankTransfer.Payment(34000, 567898765 ,"Txn00989");
         bankTransfer.Payment(89000 , "Chq009865", "23/10/2026", 290541);
    }
}

class BankTransfer
{
    public void Payment(double amount)
    {
        Console.WriteLine("Payment received through cash " + amount);   
    }

    public void Payment(double amount, string upiid)
    {
        Console.WriteLine("Payment received by UPI : " +amount);
        Console.WriteLine("UPI Id : " +upiid);
    }

    public void Payment(double amount, int cardnumber, string txnid)
    {
        Console.WriteLine("Payment received by UPI : " +amount);
        Console.WriteLine("Card Number : " +cardnumber);
        Console.WriteLine("Txn Id : " +txnid);
    }

    public void Payment(double amount, string chqnumber, string date, int accountnum)
    {
        
        Console.WriteLine("Date : " +date);
        Console.WriteLine("Account Number : " +accountnum);
        Console.WriteLine("Payment received by UPI : " +amount);
        Console.WriteLine("Cheque Number : " +chqnumber);
        
    }

}