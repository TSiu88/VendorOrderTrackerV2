using Microsoft.AspNetCore.Mvc;
using VendorOrders.Models;
using System.Collections.Generic;

namespace VendorOrders.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId) 
    { 
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor); 
    }

    [HttpGet("vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId) 
    { 
      Vendor foundVendor = Vendor.Find(vendorId);
      Order foundOrder = Order.Find(orderId);
      
      Dictionary<string,object> model = new Dictionary<string,object>();
      model.Add("order", foundOrder);
      model.Add("vendor", foundVendor);
      return View(model); 
    }
  }
}