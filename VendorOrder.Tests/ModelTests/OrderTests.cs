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
    public string itemOne;
    public string descriptionOne;
    public int amountOne;
    public double costOne;
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestInitialize]
    public void TestInitialize()
    {
      itemOne = "Sandevistan";
      descriptionOne = "REDACTED";
      amountOne = 2;
      costOne = 12999.98;
      DateTime date = new DateTime(2077, 09, 30);
      orderOne = new Order(itemOne, descriptionOne, amountOne, costOne, date);
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Assert.AreEqual(typeof(Order), orderOne.GetType());
    }

    [TestMethod]
    public void GetitemOne_ReturnsitemOne_String()
    {
      string result = orderOne.Item;
      Assert.AreEqual(itemOne, result);
    }

  }
}