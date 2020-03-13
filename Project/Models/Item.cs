using System;
using System.Collections.Generic;

namespace ProjectName.Models
{
  public class Item
  {
    public string Property { get; set; }
    private static List<Item> _instances = new List<Item>() {};
    public int Id { get; }
    public Item(string property)
    {
      Property = property;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}