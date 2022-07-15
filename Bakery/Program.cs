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
      Console.WriteLine("Welcome to Pierres Bakery");
      Console.WriteLine("We currently have a buy 2 get 1 free on our loaves of bread. Individually priced at $" + Bread.Price +" each");
      Console.WriteLine("Pastries are $2 each. Or bundle and save 3/$5, 4/$7, 5/$9, 6/$10.");
      Console.WriteLine("Please select category:");
      Console.WriteLine(" '1' for Bread |  '2' for Pastries");
      string menuType = Console.ReadLine();
      if ( menuType == "1")
      {
        Console.WriteLine("Perfect, how many loaves would you like today?");
        int breadAmount = int.Parse(Console.ReadLine());
        Bread breadOrder = new Bread(breadAmount);
        Console.WriteLine("For " + breadOrder.Quantity + " loaves of bread your total is $" + breadOrder.BreadCost());


      }
      else if( menuType == "2")
      {
        Console.WriteLine("Great choice! How many pastries would you like?");
        int pastryAmount = int.Parse(Console.ReadLine());
        Pastry pastryOrder = new Pastry(pastryAmount);
        Console.WriteLine("For " + pastryOrder.Quantity + " pastries your total will be $" + pastryOrder.PastryCost());
        Program.totalList.Add(pastryOrder.PastryCost());
        
      }
      else
      {
        Main();
      }
    }
    public static List<int> totalList = new List<int> {};
    public void FinishShopping()
    {
      Console.WriteLine("All set? Y/N");
      string checkout = (Console.ReadLine().ToUpper());

      if (checkout == "Y")
      {
        int total = 0;
        for(int i = 0; i < totalList.Count; i ++)
        {
          total += totalList[i];
        }
        Console.WriteLine(" Here is your full order: ");
        Environment.Exit(0);
      }
      else
      {
        StartBakeryMenu();
      }
    }
  }
}