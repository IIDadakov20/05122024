using HrManagement.Domain.DTOs.Request;
using HrManagement.Domain.DTOs.Response;

namespace HrManagement.Infrastructure.Contracts;

public interface IEmployeeService
{
    public EmployeeResponseDTO GetEmployee(int id);
    
    public bool InsertEmployee(EmployeeRequestDTO employee);

    public bool UpdateEmployee(EmployeeRequestDTO employee);
    
    public bool DeleteEmployee(int id);
}