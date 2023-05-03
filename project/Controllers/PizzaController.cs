using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View(Listino.Pizze);
        }
    }
}
