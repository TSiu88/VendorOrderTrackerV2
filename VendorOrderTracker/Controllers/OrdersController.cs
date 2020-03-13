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

    [HttpGet("/orders/new")]
    public ActionResult New() { return View(); }

    [HttpPost("/orders")]
    public ActionResult Create(string title, string description, string date, int price) 
    { 
      Order myOrder = new Order(title, description, date, price);
      return RedirectToAction("Index"); 
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