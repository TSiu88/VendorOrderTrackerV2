using System;
using System.Collections.Generic;

namespace VendorOrders.Models
{
  public class Vendor
  {
    public string Property { get; set; }
    private static List<Vendor> _instances = new List<Vendor>() {};
    public int Id { get; }
    public Vendor(string property)
    {
      Property = property;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}