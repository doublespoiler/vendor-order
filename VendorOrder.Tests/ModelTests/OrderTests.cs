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
    public string itemTwo;
    public string descriptionOne;
    public string descriptionTwo;
    public int amountOne;
    public int amountTwo;
    public double costOne;
    public double costTwo;
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
      itemTwo = "Eclipse";
      descriptionTwo = "REDACTED";
      amountTwo = 3;
      costTwo = 27999.88;
      DateTime date = new DateTime(2077, 09, 30);
      orderOne = new Order(itemOne, descriptionOne, amountOne, costOne, date);
      orderTwo = new Order(itemTwo, descriptionTwo, amountTwo, costTwo, date);
      orderList = new List<Order> { orderOne, orderTwo};
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
    [TestMethod]
    public void GetAll_ReturnsList_List()
    {
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(orderList, result);
    }
  }
}