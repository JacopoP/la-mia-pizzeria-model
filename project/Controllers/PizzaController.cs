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

        public IActionResult PizzaDetail(int id)
        {
            Pizza pizza = Listino.Pizze.FirstOrDefault(p => p.Id == id);
            return View(pizza);
        }
    }
}
