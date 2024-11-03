using Microsoft.AspNetCore.Mvc;
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
    }
}
