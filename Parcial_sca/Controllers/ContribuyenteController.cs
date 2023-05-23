using Microsoft.AspNetCore.Mvc;
using Parcial_sca.Models;

namespace Parcial_sca.Controllers
{
    public class ContribuyenteController : Controller
    {
        public static List<Contribuyente> listaContribuyentes = new List<Contribuyente>();

        public IActionResult Index()
        {
            return View(listaContribuyentes);
        }

        public IActionResult AddC()
        {
            return View();
        }
    }
}
