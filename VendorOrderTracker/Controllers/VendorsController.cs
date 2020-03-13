using Microsoft.AspNetCore.Mvc;
using VendorOrders.Models;
using System.Collections.Generic;

namespace VendorOrders.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index() 
    { 
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New() { return View(); }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description) 
    { 
      Vendor myVendor = new Vendor(name, description);
      return RedirectToAction("Index"); 
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id) 
    { 
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(id);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
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
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }
  }
}