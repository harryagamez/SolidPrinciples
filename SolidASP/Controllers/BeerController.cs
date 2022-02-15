using Microsoft.AspNetCore.Mvc;
using SolidASP.Models.ViewModels;
using SolidASP.Services;

namespace SolidASP.Controllers
{
    public class BeerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(BeerViewModel beer)
        {
            if (!ModelState.IsValid)
            {
                return View(beer);
            }

            var beerService = new BeerService();
            beerService.Create(beer);

            // Guardado de BD

            // Guardado en log

            return Ok();
        }
    }
}
