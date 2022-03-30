using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
			// Greet the user and get the input
			Console.WriteLine("Welcome to Money Maker");
			Console.WriteLine("Enter an amount to convert to coins:");
			
			string total = Console.ReadLine();
			double coinNumber = Convert.ToDouble(total);
			
			Console.WriteLine($"{coinNumber} cents is equal too...");
			
			// Define coin values
			int goldValue = 10;
			int silverValue = 5;
			
      // Calculate the change
			double goldCoins = Math.Floor(coinNumber / goldValue);
			double remainder = coinNumber % goldValue;
			double silverCoins = Math.Floor(remainder / silverValue);
			remainder = remainder % silverValue;

      // Print the results
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");      
    }
  }
}
