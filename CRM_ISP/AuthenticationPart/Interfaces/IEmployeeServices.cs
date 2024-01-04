using CRM_ISP.Models;

namespace CRM_ISP.AuthenticationPart.Interfaces
{
    public interface IEmployeeServices
    {
        public List<Employee> GetEmployeeDetails();

        public Employee AddEmployee(Employee employee);

    }
}
