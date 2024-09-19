using Microsoft.AspNetCore.Mvc;

namespace CustomersAPIProject.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
