using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging.Signing;

namespace CRUD.Controllers
{
    public class CustomerController : Controller
    {
        private readonly TrainingContext _context;

        public CustomerController(TrainingContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Customer> oblist = _context.Customer;
            return View(oblist);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer ob)
        {
            if(ModelState.IsValid)
            {
                _context.Customer.Add(ob);
                _context.SaveChanges();
                TempData["message"] = "Recorded Added Successfully";
                return RedirectToAction("Index");
            }

            return View(ob);
        }
        public IActionResult Edit(int? id)
        {
            if(id==null||id==0)
            {
                return NotFound();
            }
            var cusob = _context.Customer.Find(id);
            if(cusob==null)
            {
                return NotFound();
            }

            return View(cusob);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Customer cusob)
        {
            if(ModelState.IsValid)
            {
                _context.Customer.Update(cusob);
                _context.SaveChanges();

                TempData["message"] = "Data update successfully";
                return RedirectToAction("Index");

            }
            return View(cusob);
        }

        public IActionResult Delete(int id)
        {
            if( id==0)
            {
                return NotFound();
            }
            var customerob= _context.Customer.Find(id);
            if(customerob==null)
            {
                return NotFound();
            }
            return View(customerob);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleleCustomer(int id)
        {
            var customeob= _context.Customer.Find(id);

            if(customeob==null)
            {
                return NotFound();

            }
            _context.Customer.Remove(customeob);
            _context.SaveChanges();
            TempData["message"] = "Delete Data Successfuly";
            return RedirectToAction("Index");
        }
       

    }
}
