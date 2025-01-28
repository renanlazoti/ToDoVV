using Microsoft.AspNetCore.Mvc;

namespace ToDoVV.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
