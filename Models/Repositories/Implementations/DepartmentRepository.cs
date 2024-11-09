using SchoolApp.Models.Context;
using SchoolApp.Models.Entities;
using SchoolApp.Models.Repositories.Interfaces;

namespace SchoolApp.Models.Repositories.Implementations
{
    public class DepartmentRepository : IDepartmentRepository
    {
        //In every repository, inject the context class
        protected readonly ApplicationDbContext _context;  
        public DepartmentRepository(ApplicationDbContext context) 
        {
            _context = context; 
        }   
        public Department AddDepartment(Department department)
        {
            //The method below use the context class to add a new department to the department table 
            _context.Departments.Add(department);
            _context.SaveChanges();
            return department;
        }

        
        public void DeleteDepartment(Department department)
        {
            _context.Departments.Remove(department);
            _context.SaveChanges();
            
        }

        public List<Department> GetAll()
        {
            //It returns all departments from the department table
            var departments = _context.Departments.ToList();
            return departments;
        }

        public Department GetDepartment(int id)
        {
            var department = _context.Departments.Find(id);
            return department;
        }

        public Department UpdateDepartment(Department department)
        {
            _context.Departments.Update(department);
            _context.SaveChanges();
            return department;
        }
    }
}
