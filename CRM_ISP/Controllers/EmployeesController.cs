using CRM_ISP.AuthenticationPart.Interfaces;
using CRM_ISP.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRM_ISP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeServices _employeeServices;

        public EmployeesController(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }


        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return _employeeServices.GetEmployeeDetails();
        }

        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<EmployeesController>
        
        [HttpPost]
        public Employee AddEmployeer([FromBody] Employee emp)
        {
            var employee = _employeeServices.AddEmployee(emp);
            return employee;
        }
    }
}
