using Microsoft.AspNetCore.Mvc;


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

    [HttpGet("/vendors/{id}/orders/{id}")]
    public ActionResult Show()
    {
      return View();
    }

  }
}