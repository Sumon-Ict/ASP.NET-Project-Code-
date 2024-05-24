using CrudOperation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudOperation.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly TrainingDbContext _context;
        public EmployeeController(TrainingDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult>Index()
        {
            var employees = await _context.Employees.ToListAsync();
            return View(employees);

        }
        
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Add(AddEmployeeViewModel ob)
        {
            var empob = new Employee()
            {
                Id = Guid.NewGuid(),
                Name= ob.Name,
                Department = ob.Department,
                Salary = ob.Salary,
                DateOfBirth = ob.DateOfBirth,

            };
           await _context.Employees.AddAsync(empob);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]

        public async Task< IActionResult> View(Guid id)
        {
            var emob = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if (emob!=null)
            {
                var ob = new UpdateViewModel()
                {
                    Id = emob.Id,
                    Name = emob.Name,
                    Department = emob.Department,
                    Salary = emob.Salary,
                    Email = emob.Email,
                    DateOfBirth=emob.DateOfBirth,

                };
                return await Task.Run(()=> View("View",ob));

            }

            return RedirectToAction("Index");

        }



        [HttpPost]
        public async Task<IActionResult>View(UpdateViewModel model)
        {
           
            var employee = await _context.Employees.FindAsync(model.Id);

            if (employee!=null)
            {
                employee.Name=model.Name;
                employee.Department=model.Department;
                employee.Salary=model.Salary;
                employee.Email=model.Email;
                employee.DateOfBirth=model.DateOfBirth;
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");

            }

            return RedirectToAction("Index");

        }

        [HttpPost]
        public async Task<IActionResult>Delete(UpdateViewModel model)
        {
            var employee = await _context.Employees.FindAsync(model.Id);

            if(employee!=null)
            {
                 _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");

            }

            return RedirectToAction("Index");
        }



    }
}
