using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace VendorOrders.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    private static List<Vendor> _instances = new List<Vendor>() {};
    public int Id { get; }
    public List<Order> Orders { get; set; }
    public Dictionary<int,DateTime> OrderDates { get; set;}
    public Dictionary<int,DateTime> SortedDates { get; set;}

    public Vendor(string name, string description, string address, string phone, string email)
    {
      Name = name;
      Description = description;
      Address = address;
      PhoneNumber = phone;
      Email = email;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
      OrderDates = new Dictionary<int, DateTime>{};
      SortedDates = new Dictionary<int, DateTime>{};
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static int VendorCount()
    {
      return _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
      OrderDates.Add(order.Id,Convert.ToDateTime(order.Date));
      SortedDates = OrderDates.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
    }

    public static void LoadInitialData()
    {
      using (StreamReader jsonData = new StreamReader("wwwroot/SeedData.json"))
      {
        List<Vendor> initialVendors = JsonConvert.DeserializeObject<List<Vendor>>(jsonData.ReadToEnd());

        foreach (Vendor vendor in initialVendors)
        {
          foreach (Order order in vendor.Orders)
          {
            vendor.OrderDates.Add(order.Id,StringToDate(order.Date));
            vendor.SortedDates = vendor.OrderDates.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
          }
        }
      }
    }

    public static DateTime StringToDate(string dateString)
    {
      string[] dateAsStrings = new string[]{};
      bool dateMDYFormat;
      if (dateString.Contains("-"))
      {
        dateAsStrings = dateString.Split("-");
        dateMDYFormat = true;
      }
      else if (dateString.Contains("/"))
      {
        dateAsStrings = dateString.Split("/");
        dateMDYFormat = false;
      }
      else
      {
        Console.WriteLine("Error in datetime from: " + dateString);
        dateMDYFormat = false;
      }
      List<int> dateAsInts = new List<int>();
      foreach (string datePart in dateAsStrings)
      {
        bool conversionSuccessful = Int32.TryParse(datePart, out int intDate);
        if (conversionSuccessful == true)
        {
          dateAsInts.Add(intDate);
        }
      }
      int[] dateNumbers = dateAsInts.ToArray();
      DateTime convertedDate;
      if (dateNumbers.Length == 3 && dateMDYFormat == true)
      {
        convertedDate = new DateTime(dateNumbers[2], dateNumbers[0], dateNumbers[1]);
      }
      else if (dateNumbers.Length == 3 && dateMDYFormat == false)
      {
        convertedDate = new DateTime(dateNumbers[0], dateNumbers[1], dateNumbers[2]);
      }
      else
      {
        convertedDate = DateTime.Today;
      }
      return convertedDate;
    }
  }
}