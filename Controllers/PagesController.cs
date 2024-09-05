using Microsoft.AspNetCore.Mvc;

namespace Personal.Controllers;

public class PagesController : Controller
{
    public IActionResult Resume()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }
}
