using FirstDemo.Models;
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
            var model=new SummaryModel("Hellow world","sumon","bogura",100);
           

            return View(model);

                
        }
    }
}
