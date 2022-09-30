using Microsoft.AspNetCore.Mvc;


namespace VendorOrder.Controllers
{
    public class VendorController : Controller
    {
       [HttpGet("/vendors")]
       public ActionResult Index()
       {
        return View();
       }

       [HttpGet("/vendors/new")]
       public ActionResult New()
       {
        return View();
       }

       [HttpPost("/vendors")]
       public ActionResult Create()
       {
        return View();
       }

       [HttpGet("/vendors/{id}")]
       public ActionResult Show()
       {
        return View();
       }
    }
}