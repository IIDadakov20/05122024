using HrManagement.Domain.DTOs.Request;
using HrManagement.Infrastructure.Contracts;
using HrManagement.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace HrManagement.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class EmployeeController: Controller
{
    [HttpGet]
    public IActionResult Get([FromQuery] int id)
    {
        IEmployeeService s = new EmployeeService();
        return Ok(s.GetEmployee(id));
    }

    [HttpPost]
    public IActionResult Add([FromBody] EmployeeRequestDTO employee)
    {
        IEmployeeService s = new EmployeeService();
        return Ok(s.InsertEmployee(employee));
    }

    [HttpPut]
    public IActionResult Update([FromBody] EmployeeRequestDTO employee)
    {
        IEmployeeService s = new EmployeeService();
        return Ok(s.UpdateEmployee(employee));
    }

    [HttpDelete]
    public IActionResult Delete([FromQuery] int id)
    {
        IEmployeeService s = new EmployeeService();
        return Ok(s.DeleteEmployee(id));
    }
}