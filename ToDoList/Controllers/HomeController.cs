using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]     // root path
      public ActionResult Index()
      {
        return View();
      }

    }
}
