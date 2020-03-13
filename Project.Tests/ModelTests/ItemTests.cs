using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;
using System;

namespace ProjectName.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }
    // Test methods go here
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("property");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      Item newItem = new Item("property");
      string result = newItem.Property;
      Assert.AreEqual("Expected", result);
    }
  }
}