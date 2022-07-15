using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests 
  {

    [TestMethod]
    public void PastryCost_CostOnePastryNoDiscount_Int()
    {
      // arrange
      int pastryQuantity = 1;
      double pastryCost = 2;
      // act //
      Pastry pastryOrder = new Pastry(pastryQuantity);
      // assert
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
    [TestMethod]
    public void PastryCost_CostThreePastryDiscount_Int()
    {
      // arrange
      int pastryQuantity = 3;
      double pastryCost = 5;
      
      // act //
      Pastry pastryOrder = new Pastry(pastryQuantity);
      // assert
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
    [TestMethod]
    public void PastryCost_CostFourPastryDiscount_Int()
    {
      // arrange
      int pastryQuantity = 4;
      double pastryCost = 7;
      
      // act //
      Pastry pastryOrder = new Pastry(pastryQuantity);
      // assert
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }

  }
}