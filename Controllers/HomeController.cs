using Microsoft.AspNetCore.Mvc;

using Personal.Repositories;

namespace Personal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var links = LinksRepository.List;
            var homePage = new PagesRepository().GetByTitle("Home");

            ViewBag.Links = links;
            ViewBag.HomePage = homePage;

            return View();
        }
    }
}