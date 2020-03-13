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
    public ActionResult Create(string param, string par) 
    { 
      Vendor myVendor = new Vendor(param, par);
      return RedirectToAction("Index"); 
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id) 
    { 
      Vendor foundVendor = Vendor.Find(id);
      return View(foundVendor); 
    }

    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }
  }
}