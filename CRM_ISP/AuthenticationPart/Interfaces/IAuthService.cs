using CRM_ISP.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM_ISP.AuthenticationPart.Interfaces
{
    public interface IAuthService
    {
        Admin RegisterAdmin(Admin admin);

        User RegisterUser(User user);

        string LogIn(LoginRequest loginRequest);

        Role AddRole(Role role);

        bool AssignRoleToUser(AddUserRole obj);
        List<User> GetUsers();
        int getTotalUsers();

    }

}
