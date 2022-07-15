using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery
{
  public class Program
  {
   public static void Main() 
   {
    Console.WriteLine("Bienvenue à Pierre's Boulangerie");
    
    StartBakeryMenu();
   }
   public static void StartBakeryMenu()
   {
    Console.WriteLine("Welcome to Pierres Bakery")
    Console.WriteLine("We currently have a buy 2 get 1 free on our loaves of bread. Individually priced at $" + Bread.Price " each");
    Console.WriteLine("Pastries are $2 each. Or bundle and save 3/$5, 4/$7, 5/$9, 6/$10.")
    Console.WriteLine("Please select category:");
    Console.WriteLine(" '1' for Bread |  '2' for Pastries");
    string menuType = Console.ReadLine();
    if ( menuType == "1")
    {
      Console.WriteLine("Perfect, how many loaves would you like today?");
      int 
    }
    else if( menuType == "2")
    {
      Pastry.PastryCost();
    }
    else
    {
      Main();
    }
   }
  }
}