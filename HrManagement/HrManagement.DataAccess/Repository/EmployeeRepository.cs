using HrManagement.DataAccess.Data;
using HrManagement.DataAccess.Data.Models;
using HrManagement.DataAccess.Repository.Base;

namespace HrManagement.DataAccess.Repository;

public class EmployeeRepository : GenericRepository<Employee>
{
    public EmployeeRepository(ApplicationDbContext context) : base(context)
    {
        
    }

    protected override void UpdateEntity(Employee oldEntity, Employee newEntity)
    {
        oldEntity.Name = newEntity.Name;
        oldEntity.Position = newEntity.Position;
        oldEntity.Salary = newEntity.Salary;
        oldEntity.HireDate = newEntity.HireDate;
        oldEntity.DepartmentId = newEntity.DepartmentId;
    }

    protected override void DeleteAdditionalDependancies()
    {
        throw new NotImplementedException();
    }
}