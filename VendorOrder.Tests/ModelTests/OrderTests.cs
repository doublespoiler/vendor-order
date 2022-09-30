using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests 
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public Order orderOne;
    public Order orderTwo;
    public List<Order> orderList;
    public DateTime date;
    public string item;
    public string description;
    public int amount;
    public double cost;
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestInitialize]
    public void TestInitialize()
    {
      item = "Sandevistan";
      description = "REDACTED";
      amount = 2;
      cost = 12999.98;
      DateTime date = new DateTime(2077, 09, 30);
      orderOne = new Order(item, description, amount, cost, date);
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Assert.AreEqual(typeof(Order), orderOne.GetType());
    }

  }
}