using CRM_ISP.AuthenticationPart.Interfaces;
using CRM_ISP.Models;

namespace CRM_ISP.AuthenticationPart.Services
{
    public class EmployeeService : IEmployeeServices
    {
        private readonly CrmDbContext _context;

        public EmployeeService(CrmDbContext context)
        {
            _context = context;
        }

        public Employee AddEmployee(Employee employee)
        {
            var emp = _context.Employees.Add(employee);
            _context.SaveChanges();
            return emp.Entity;
        }

        public List<Employee> GetEmployeeDetails()
        {
            var employees = _context.Employees.ToList();
            return employees;
        }
    }
}
