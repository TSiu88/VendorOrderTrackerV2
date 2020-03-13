using Microsoft.AspNetCore.Mvc;
using VendorOrders.Models;
using System.Collections.Generic;

namespace VendorOrders.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index() 
    { 
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId) 
    { 
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor); 
    }

    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id) 
    { 
      Order foundOrder = Order.Find(id);
      return View(foundOrder); 
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }
  }
}