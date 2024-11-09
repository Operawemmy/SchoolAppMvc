using Microsoft.AspNetCore.Mvc;
using SchoolApp.Models.Entities;
using SchoolApp.Models.Repositories.Interfaces;

namespace SchoolApp.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _repository;
        public DepartmentController(IDepartmentRepository repository) 
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var departments = _repository.GetAll();
            return View(departments);
        }

        public IActionResult GetDepartment(int id) 
        {
            var department = _repository.GetDepartment(id);
            return View(department);
        }

        public IActionResult AddDepartment() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDepartment(int id, string name, string description, string code) 
        {
            var department = new Department
            {
                Id = id,
                Name = name,
                Description = description,
                Code = code
            };
            _repository.AddDepartment(department);
            return RedirectToAction("Index");
        }
    }
}
