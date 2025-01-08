namespace HrManagement.Domain.DTOs.Response;

public class EmployeeResponseDTO
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Position { get; set; } = null!;
}