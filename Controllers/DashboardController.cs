 using Microsoft.AspNetCore.Mvc;

namespace Travel2.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Display()
        {
            return View();
        }
    }
}
