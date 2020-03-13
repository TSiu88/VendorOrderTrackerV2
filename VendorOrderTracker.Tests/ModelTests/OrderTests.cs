using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrders.Models;
using System;

namespace VendorOrders.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    // Test methods go here
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("property");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   Order newOrder = new Order("property");
    //   string result = newOrder.Property;
    //   Assert.AreEqual("Expected", result);
    // }
  }
}