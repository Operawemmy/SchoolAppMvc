using SchoolApp.Models.Entities;

namespace SchoolApp.Models.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        Department GetDepartment(int id);   
        List<Department> GetAll();
        Department AddDepartment(Department department);
        Department UpdateDepartment(Department department); 
        void DeleteDepartment(Department department);
    }
}
