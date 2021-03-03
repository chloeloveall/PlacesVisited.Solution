using Microsoft.AspNetCore.Mvc;
using Template.Models;
// using System.Collections.Generic;

// change this namespace 
namespace Template.Controllers
{
  //change this class name
  public class TempsController : Controller
  {
    // change this route decorator
    [HttpGet("/temps")]
    public ActionResult Index()
    {
      return View();
    }

  }
}