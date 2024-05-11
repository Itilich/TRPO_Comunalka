using Microsoft.AspNetCore.Mvc;

namespace TRPO_Comunalka.Web.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
