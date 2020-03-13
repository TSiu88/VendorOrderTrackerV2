using Microsoft.AspNetCore.Mvc;
using VendorOrders.Models;

namespace VendorOrders.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() { return View(); }
  }
}