using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;  //to use the list

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")] //root path aka index() route 
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return RedirectToAction("Index");  
    }

  }
}
