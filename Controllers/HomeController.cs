using Microsoft.AspNetCore.Mvc;
using Personal.Repositories;

namespace Personal.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(LinkRepository.List);
    }
}
