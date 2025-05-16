using Microsoft.AspNetCore.Mvc;

namespace hospital_api.Controllers
{
    public class MedicosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
