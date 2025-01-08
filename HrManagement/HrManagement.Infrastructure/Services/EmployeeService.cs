using HrManagement.DataAccess.Data;
using HrManagement.DataAccess.Data.Models;
using HrManagement.DataAccess.Repository;
using HrManagement.Domain.DTOs.Request;
using HrManagement.Domain.DTOs.Response;
using HrManagement.Infrastructure.Contracts;

namespace HrManagement.Infrastructure.Services;

public class EmployeeService : IEmployeeService
{
    public EmployeeResponseDTO GetEmployee(int id)
    {
        EmployeeRepository repository = new EmployeeRepository(new ApplicationDbContext());
        return repository.GetById(id)
            .Select(employee => new EmployeeResponseDTO
            {
                Id = employee.Id,
                Name = employee.Name,
                Position = employee.Position,
            }).First();
    }
    
    public bool InsertEmployee(EmployeeRequestDTO employee)
    {
        EmployeeRepository repository = new EmployeeRepository(new ApplicationDbContext());
        return repository.Add(new Employee()
        {
            DepartmentId = employee.DepartmentId,
            HireDate = employee.HireDate,
            Name = employee.Name,
            Position = employee.Position,
            Salary = employee.Salary
        });
    }

    public bool UpdateEmployee(EmployeeRequestDTO employee)
    {
        EmployeeRepository repository = new EmployeeRepository(new ApplicationDbContext());
        return repository.Update(new Employee()
        {
            Id =employee.Id,
            DepartmentId = employee.DepartmentId,
            HireDate = employee.HireDate,
            Name = employee.Name,
            Position = employee.Position,
            Salary = employee.Salary
        });
    }

    public bool DeleteEmployee(int id)
    {
        EmployeeRepository repository = new EmployeeRepository(new ApplicationDbContext());
        return repository.Delete(id);
    }
}