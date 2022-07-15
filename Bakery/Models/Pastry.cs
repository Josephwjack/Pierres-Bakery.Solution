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
        // else{
        //   pastryTotal += _Price;
        // }
      }
      return pastryTotal;
    }
  }
}
// public double PastryCost()
//     {
//       double pastryTotal = 0;
//       for (int index = 0; index <= Quantity; index++)
//       {
//         if (index == 0)
//         {
//           pastryTotal += 0;
//         }
//         else if (index % 2 == 0)
//         {
//           pastryTotal += _Price * _Discount;
//         }
//         else{
//           pastryTotal += _Price;
//         }
//       }
//       return pastryTotal;
//     }
//   }
// }




/// Program - main menu
// Try using Bakery.Models namespace for both pastry and bread class
// auto implemented properties -- methods for determining price -- recieve prompt with welcome message and cost for both 
// user should be able to specify how many
// app returns cost
// DEALS:
// Bread - buy 2 get 1 free .... 1 = $5, 2 = $10, 3 = $10
// Pastry 1 = $2, 3 = $5, 4 = $7, 5 = $9, 6 = $10