using System;
using System.Collections.Generic;
using Bakery;

namespace Bakery.Models
{
  public class Pastry
  {
    private static double _Price = 0;
    private double _Discount;
    public int Quantity { get; set; }

    public static double Price
    {
      get { return _Price; }
      set { _Price = value; }
    }
    public Pastry(int quantity)
    {
      _Price = Price;
      _Discount = 1;
      Quantity = quantity;
    } 

    public double PastryCost()
    {
      double pastryTotal = Quantity*2;
      for (int index = 1; index <= Quantity; index++)
      {
        if (index % 3 == 0)
        {
          pastryTotal -= _Discount;
        }
      }
      return pastryTotal;
    }
  }
}

