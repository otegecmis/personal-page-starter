using Microsoft.AspNetCore.Mvc;

namespace Personal.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
