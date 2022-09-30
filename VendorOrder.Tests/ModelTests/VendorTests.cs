using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests 
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public Vendor newVendor;
    public string name;

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestInitialize]
    public void TestInitialize()
    {
      name = "Arasaka";
      newVendor = new Vendor(name);
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetAll_Returns_List()
    {
      string nameTwo = "Militech";
      Vendor vendorTwo = new Vendor(nameTwo);
      List<Vendor> newList = new List<Vendor> { newVendor, vendorTwo};

      List<Vendor> result =  Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

  }
}