using Microsoft.AspNetCore.Mvc;

    // change this namespace
    namespace Template.Controllers
    {
        public class HomeController : Controller
        {

          [HttpGet("/")]
          public ActionResult Index()
          {
            return View();
          }

        }
    }