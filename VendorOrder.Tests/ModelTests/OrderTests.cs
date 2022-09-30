using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests 
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string item = "bread";
      string description = "for bread";
      DateTime date = new DateTime(2022, 09, 22);
      Order newOrder = new Order(item, description, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

  }
}