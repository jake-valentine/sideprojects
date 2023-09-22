using System;

namespace CoinConverter
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to my Coin Converter!");
      Console.WriteLine("Enter an amount " + "(" + "in cents" + ") " + "to convert to coins?");
      string total = Console.ReadLine();
      double trueTotal = Convert.ToDouble(total);
      int fifty = 50;
      int quarter = 25;
      int dime = 10;
      int nickel = 5;
      double Fiftycent = Math.Floor(trueTotal / 50);
      double LeftoverFromFifty = Math.Floor(trueTotal % 50);
      double Quarters = Math.Floor(LeftoverFromFifty / 25);
      double LeftoverFromQuarters = Math.Floor(LeftoverFromFifty % 25);
      double Dimes = Math.Floor(LeftoverFromQuarters / 10);
      double LeftoverFromDimes = Math.Floor(LeftoverFromQuarters % 10);
      double Nickels = Math.Floor(LeftoverFromDimes / 5);
      double LeftoverFromNickels = Math.Floor(LeftoverFromDimes % 5);
      double Pennies = LeftoverFromNickels;
      Console.WriteLine($"{trueTotal} cents is equal to...");
      Console.WriteLine($"Fifty Cent coins: {Fiftycent} ");
      Console.WriteLine($"Quarters: {Quarters} ");
      Console.WriteLine($"Dimes: {Dimes} ");
      Console.WriteLine($"Nickels: {Nickels} ");
      Console.WriteLine($"Pennies: {Pennies} ");

    }
  }
}
