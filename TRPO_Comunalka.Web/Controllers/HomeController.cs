using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TRPO_Comunalka.Web.Models;

namespace TRPO_Comunalka.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new CommunalkaModel());
        }
        [HttpPost]
        public IActionResult Calculate(CommunalkaModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            try
            {
                double summa = TRPO_Comunalka.Lib.Comunalka.Com(model.L, model.H, model.C, model.F, model.T, model.En, model.Kap, model.Space);
                ViewBag.summa = "Сумма к оплате: " + summa.ToString("0.00") + " руб.";
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Ошибка: " + ex.Message;
            }

            return View("Index", model);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}