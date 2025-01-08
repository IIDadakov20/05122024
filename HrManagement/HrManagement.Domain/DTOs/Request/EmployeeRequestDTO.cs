using HrManagement.DataAccess.Data.Models;

namespace HrManagement.Domain.DTOs.Request;

public class EmployeeRequestDTO
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Position { get; set; } = null!;

    public DateTime HireDate { get; set; }

    public int Salary { get; set; }

    public int DepartmentId { get; set; }
}