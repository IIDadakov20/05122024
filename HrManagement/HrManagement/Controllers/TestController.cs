using HrManagement.DataAccess.Data;
using HrManagement.DataAccess.Data.Models;
using HrManagement.DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HrManagement.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController: Controller
{
    [HttpGet]
    public IActionResult Test([FromQuery] int id)
    {
        EmployeeRepository e = new EmployeeRepository(new ApplicationDbContext());
        return Ok(e.GetById(id));
    }
}