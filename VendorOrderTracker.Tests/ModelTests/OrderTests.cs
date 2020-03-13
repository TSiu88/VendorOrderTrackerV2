using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrders.Models;
using System;
using System.Collections.Generic;

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
      Order newOrder = new Order("title", "description", "date", 5);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
      Assert.AreEqual("title", newOrder.Title);
      Assert.AreEqual("description", newOrder.Description);
      Assert.AreEqual("date", newOrder.Date);
      Assert.AreEqual(5, newOrder.Price);
    }

    [TestMethod]
    public void GetAll_ReturnAllOrdersInList_ListOfOrders()
    {
      Order newOrder1 = new Order("title", "description", "date", 5);
      Order newOrder2 = new Order("title", "description", "date", 5);
      Order newOrder3 = new Order("title", "description", "date", 5);
      List<Order> expectedOrders = new List<Order> {newOrder1, newOrder2, newOrder3};
      CollectionAssert.AreEquivalent(expectedOrders, Order.GetAll());
    }

    [TestMethod]
    public void ClearAll_ClearAllOrdersInList_EmptyListOfOrders()
    {
      Order newOrder1 = new Order("title", "description", "date", 5);
      Order newOrder2 = new Order("title", "description", "date", 5);
      Order newOrder3 = new Order("title", "description", "date", 5);
      List<Order> expectedOrders = new List<Order> {};
      Order.ClearAll();
      CollectionAssert.AreEquivalent(expectedOrders, Order.GetAll());
    }

    [TestMethod]
    public void Find_FindOrderInListById_Order2()
    {
      Order newOrder1 = new Order("title", "description", "date", 5);
      Order newOrder2 = new Order("title", "description", "date", 5);
      Order newOrder3 = new Order("title", "description", "date", 5);
      Assert.AreSame(newOrder2, Order.Find(2));
    }
  }
}