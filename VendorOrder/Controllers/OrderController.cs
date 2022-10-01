using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrder.Models;


namespace VendorOrder.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create()
    {
      return View();
    }

  }
}