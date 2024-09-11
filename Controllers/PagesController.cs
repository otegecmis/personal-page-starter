using Microsoft.AspNetCore.Mvc;
using Personal.Repositories;

namespace Personal.Controllers;

public class PagesController : Controller
{
    public IActionResult Resume()
    {
        var repository = new PagesRepository();
        var page = repository.GetByTitle("Resume");

        return View(page);
    }

    public IActionResult Contact()
    {
        var repository = new PagesRepository();
        var page = repository.GetByTitle("Contact");

        return View(page);
    }
}
