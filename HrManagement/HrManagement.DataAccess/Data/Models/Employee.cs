﻿namespace HrManagement.DataAccess.Data.Models;

public partial class Employee : IBaseModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Position { get; set; } = null!;

    public DateTime HireDate { get; set; }

    public int Salary { get; set; }

    public int DepartmentId { get; set; }

    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    public virtual Department Department { get; set; } = null!;
}
