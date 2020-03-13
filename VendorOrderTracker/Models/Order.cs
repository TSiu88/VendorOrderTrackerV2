using System;
using System.Collections.Generic;

namespace VendorOrders.Models
{
  public class Order
  {
    public string Property { get; set; }
    private static List<Order> _instances = new List<Order>() {};
    public int Id { get; }
    public Order(string property)
    {
      Property = property;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}