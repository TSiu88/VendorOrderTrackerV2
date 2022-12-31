using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrders.Models;
using System;
using System.Collections.Generic;

namespace VendorOrders.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    // Test methods go here
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name", "description","address","phone","email");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
      Assert.AreEqual("name", newVendor.Name);
      Assert.AreEqual("description", newVendor.Description);
      Assert.AreEqual("address", newVendor.Address);
      Assert.AreEqual("phone", newVendor.PhoneNumber);
      Assert.AreEqual("email", newVendor.Email);
      Assert.AreEqual(1, newVendor.Id);
    }

    [TestMethod]
    public void GetAll_ReturnListOfAllVendors_ListOfVendors()
    {
      Vendor newVendor1 = new Vendor("name", "description","address","phone","email");
      Vendor newVendor2 = new Vendor("name", "description","address","phone","email");
      Vendor newVendor3 = new Vendor("name", "description","address","phone","email");
      List<Vendor> expectedList = new List<Vendor> {newVendor1, newVendor2, newVendor3};
      CollectionAssert.AreEquivalent(expectedList, Vendor.GetAll());
    }

    [TestMethod]
    public void ClearAll_ClearsListOfAllVendors_EmptyListOfVendors()
    {
      Vendor newVendor1 = new Vendor("name", "description","address","phone","email");
      Vendor newVendor2 = new Vendor("name", "description","address","phone","email");
      Vendor newVendor3 = new Vendor("name", "description","address","phone","email");
      List<Vendor> expectedList = new List<Vendor> {};
      Vendor.ClearAll();
      CollectionAssert.AreEquivalent(expectedList, Vendor.GetAll());
    }

    [TestMethod]
    public void Find_ReturnVendorWithMatchingId_Vendor2()
    {
      Vendor newVendor1 = new Vendor("name", "description","address","phone","email");
      Vendor newVendor2 = new Vendor("name", "description","address","phone","email");
      Vendor newVendor3 = new Vendor("name", "description","address","phone","email");
      Assert.AreSame(newVendor2, Vendor.Find(2));
    }

    [TestMethod]
    public void AddOrder_AddsOrderToVendor_ListOfOrders()
    {
      Vendor newVendor1 = new Vendor("name", "description","address","phone","email");
      Order newOrder = new Order("title", "description", "date", 5);
      Order newOrder2 = new Order("title", "description", "date", 5);
      newVendor1.AddOrder(newOrder);
      newVendor1.AddOrder(newOrder2);
      CollectionAssert.Contains(newVendor1.Orders, newOrder);
      CollectionAssert.Contains(newVendor1.Orders, newOrder2);
    }
  }
}