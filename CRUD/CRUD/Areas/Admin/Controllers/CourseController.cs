using Microsoft.AspNetCore.Mvc;

namespace CRUD.Areas.Admin.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
