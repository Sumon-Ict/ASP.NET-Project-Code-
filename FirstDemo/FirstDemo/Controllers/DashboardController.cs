using Microsoft.AspNetCore.Mvc;

namespace FirstDemo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            
                return View();
            
        }
        public IActionResult Summary()
        {
            return View();
                
        }
    }
}
