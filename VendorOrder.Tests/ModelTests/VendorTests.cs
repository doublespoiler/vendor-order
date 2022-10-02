using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests 
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public Vendor vendorOne;
    public Vendor vendorTwo;
    public List<Vendor> vendorList;
    public string nameOne;
    public string nameTwo;

    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestInitialize]
    public void TestInitialize()
    {
      nameOne = "Arasaka";
      vendorOne = new Vendor(nameOne);
      nameTwo = "Militech";
      vendorTwo = new Vendor(nameTwo);
      vendorList = new List<Vendor> { vendorOne, vendorTwo};
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Assert.AreEqual(typeof(Vendor), vendorOne.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string result = vendorOne.Name;
      Assert.AreEqual(nameOne, result);
    }
    [TestMethod]
    public void GetAll_Returns_List()
    {
      List<Vendor> result =  Vendor.GetAll();
      CollectionAssert.AreEqual(vendorList, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      int result = vendorOne.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(vendorTwo, result);
    }
    [TestMethod]
    public void AddOrder_AssociateOrderWithCategory_OrderList()
    {
      string itemOne = "Sandevistan";
      string descriptionOne = "REDACTED";
      int amountOne = 2;
      double costOne = 12999.98;
      DateTime date = new DateTime(2077, 09, 30);
      Order orderOne = new Order(itemOne, descriptionOne, amountOne, costOne, date);
      List<Order> newList = new List<Order> { orderOne };
      vendorOne.AddOrder(orderOne);
      List<Order> result = vendorOne.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}