﻿namespace HrManagement.DataAccess.Data.Models;

public partial class Assignment : IBaseModel
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int ProjectId { get; set; }

    public int HoursWorked { get; set; }

    public string Role { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual Project Project { get; set; } = null!;
}
