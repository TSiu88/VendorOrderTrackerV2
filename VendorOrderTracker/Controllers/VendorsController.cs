using Microsoft.AspNetCore.Mvc;
using VendorOrders.Models;
using System.Collections.Generic;
using System;

namespace VendorOrders.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index() 
    { 
      if (Vendor.VendorCount() == 0)
      {
        Vendor.LoadInitialData();
      }
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New() { return View(); }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description, string address, string phone, string email) 
    { 
      Vendor myVendor = new Vendor(name, description, address, phone, email);
      return RedirectToAction("Index"); 
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id) 
    { 
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(id);
      List<Order> vendorOrders = foundVendor.Orders;
      Dictionary<int, DateTime> orderDates = foundVendor.SortedDates;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      model.Add("dates", orderDates);
      return View(model); 
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create(int vendorId, string title, string description, string date, int price)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(title, description, date, price);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      Dictionary<int, DateTime> orderDates = foundVendor.SortedDates;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      model.Add("dates", orderDates);
      return View("Show", model);
    }
  }
}