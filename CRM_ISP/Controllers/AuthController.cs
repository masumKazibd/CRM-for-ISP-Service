using CRM_ISP.AuthenticationPart.Interfaces;
using CRM_ISP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CRM_ISP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _auth;

        public AuthController(IAuthService auth)
        {
            _auth = auth;
        }


        [HttpPost("login")]
        public string Login([FromBody] LoginRequest obj)
        {
            var token = _auth.LogIn(obj);
            return token;
        }


        [HttpPost("assignRole")]
        public bool AssignRoleToUser([FromBody] AddUserRole userRole)
        {
            var addUserRole = _auth.AssignRoleToUser(userRole);
            return addUserRole;
        }


        [HttpPost("addAdmin")]
        public Admin addAdmin([FromBody] Admin admin)
        {
            var addAdmin = _auth.RegisterAdmin(admin);
            return addAdmin;
        }

        [HttpPost("addUser")]
        public User addUser([FromBody] User user)
        {
            var addUser = _auth.RegisterUser(user);
            return addUser;
        }


        [HttpPost("addRole")]
        public Role AddRole(int id, [FromBody] Role role)
        {
            var addRole = _auth.AddRole(role);
            return addRole;
        }
    }
}
