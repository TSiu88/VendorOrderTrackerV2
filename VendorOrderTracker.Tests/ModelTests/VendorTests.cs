using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrders.Models;
using System;

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
      Vendor newVendor = new Vendor("property");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      Vendor newVendor = new Vendor("property");
      string result = newVendor.Property;
      Assert.AreEqual("Expected", result);
    }
  }
}