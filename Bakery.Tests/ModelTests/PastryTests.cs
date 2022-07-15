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
      
      int pastryQuantity = 1;
      double pastryCost = 2;
     
      Pastry pastryOrder = new Pastry(pastryQuantity);
    
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
    [TestMethod]
    public void PastryCost_CostThreePastryDiscount_Int()
    {

      int pastryQuantity = 3;
      double pastryCost = 5;
      
      Pastry pastryOrder = new Pastry(pastryQuantity);

      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
    [TestMethod]
    public void PastryCost_CostFourPastryDiscount_Int()
    {
     
      int pastryQuantity = 4;
      double pastryCost = 7;
      
      Pastry pastryOrder = new Pastry(pastryQuantity);
   
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
    [TestMethod]
    public void PastryCost_CostFivePastryDiscount_Int()
    {

      int pastryQuantity = 5;
      double pastryCost = 9;
      
      Pastry pastryOrder = new Pastry(pastryQuantity);
    
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
    [TestMethod]
    public void PastryCost_CostSixPastryDiscount_Int()
    {
    
      int pastryQuantity = 6;
      double pastryCost = 10;
      
      Pastry pastryOrder = new Pastry(pastryQuantity);
      
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
  }
}