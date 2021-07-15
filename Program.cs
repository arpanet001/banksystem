using System;

namespace bank
{
 class Program
 {
  public class account
  {
   public double balance;

   public account()
   {
    balance = 500.00;
   }

   public double deposit()
   {
    double newbalace;
    double deposit;

    Console.WriteLine("Please enter amount to deposit");
    deposit = Double.Parse(Console.ReadLine());

    newbalace = balance + deposit;

    return newbalace;
   }

   public double withdrwal()
   {
    double newbalace;
    double withdrawal;

    Console.WriteLine("Please enter amount to withdraw");
    withdrawal = double.Parse(Console.ReadLine());
    newbalace = balance - withdrawal;

    return newbalace;
   }
  }
  static void Main(string[] args)
  {
   double newbalance;
   string balance;
   account bank = new account();

   Console.WriteLine(" Your Current balance is 500.00");
   Console.WriteLine("Press d for deposuit or press w for withdrawal");

   balance = Console.ReadLine();
   if (balance == "d")
   {
    newbalance = bank.deposit();
    Console.WriteLine("Your new balance is: " + newbalance);

   }
   if (balance == "w")
   {
    newbalance = bank.withdrwal();
    Console.WriteLine("Your new balance is: " + newbalance);
   }

  }
 }
}
