using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests // : IDisposable
  {
    // public void Dispose()
    // {
    //   ClassName.ClearAll();
    // }

    [TestMethod]
    public void BreadCost_CostOneLoafNoDiscount_Int()
    {
      // arrange
      int breadQuantity = 1;
      double breadCost = 5;
      // act //
      Bread breadOrder = new Bread(breadQuantity);
      // assert
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }

     [TestMethod]
    public void BreadCost_CostTwoLoafNoDiscount_Int()
    {
      // arrange
      int breadQuantity = 2;
      double breadCost = 10;
      // act //
      Bread breadOrder = new Bread(breadQuantity);
      // assert
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }

    [TestMethod]
    public void BreadCost_CostThreeLoafDiscount_Int()
    {
      // arrange
      int breadQuantity = 3;
      double breadCost = 10;
      // act //
      Bread breadOrder = new Bread(breadQuantity);
      // assert
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }

     [TestMethod]
    public void BreadCost_CostTwelveLoafDiscount_Int()
    {
      // arrange
      int breadQuantity = 12;
      double breadCost = 48;
      // act //
      Bread breadOrder = new Bread(breadQuantity);
      // assert
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }
  }
}