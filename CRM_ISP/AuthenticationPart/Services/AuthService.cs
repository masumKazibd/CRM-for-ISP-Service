using CRM_ISP.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using CRM_ISP.AuthenticationPart.Interfaces;

namespace CRM_ISP.AuthenticationPart.Services
{
    public class AuthService : IAuthService
    {
        private readonly CrmDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthService(CrmDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;

        }

        public Role AddRole(Role role)
        {
            var addRole = _context.Roles.Add(role);
            _context.SaveChanges();
            return addRole.Entity;
        }

        public Admin RegisterAdmin(Admin admin)
        {
            var addAdmin = _context.Admins.Add(admin);
            _context.SaveChanges();
            return addAdmin.Entity;
        }

        public User RegisterUser(User user)
        {
            var addUser = _context.Users.Add(user);
            _context.SaveChanges();
            return addUser.Entity;
        }

        public bool AssignRoleToUser(AddUserRole obj)
        {
            try
            {
                var addRoles = new List<UserRoles>();
                var user = _context.Users.SingleOrDefault(s => s.UserId == obj.UserId);
                if (user == null)
                {
                    throw new Exception("User is not valid");
                }
                foreach (int role in obj.RoleIds)
                {
                    var userRole = new UserRoles();
                    userRole.RoleId = role;
                    userRole.Id = user.UserId;
                    addRoles.Add(userRole);
                }
                _context.UserRoles.AddRange(addRoles);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public List<User> GetUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }
        public int getTotalUsers()
        {
            var totalUser = _context.Users.Count();
            return totalUser;
        }

        public string LogIn(LoginRequest loginRequest)
        {
            if (loginRequest.UserEmail != null && loginRequest.Password != null)
            {
                var admin = _context.Admins.SingleOrDefault(s => s.AdminEmail == loginRequest.UserEmail && s.Password == loginRequest.Password);
                var user = _context.Users.SingleOrDefault(s => s.UserEmail == loginRequest.UserEmail && s.UserPassword == loginRequest.Password);

                if (admin != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim("Id", admin.AdminId.ToString()),
                        new Claim("UserEmail",admin.AdminEmail)
                    };

                    var userRoles = _context.UserRoles.Where(x => x.Id == admin.AdminId).ToList();
                    var roleIds = userRoles.Select(x => x.RoleId).ToList();
                    var roles = _context.Roles.Where(r => roleIds.Contains(r.RoleId)).ToList();

                    foreach (var role in roles)
                    {
                        claims.Add(new Claim("Role", role.RoleName));
                    }

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddDays(1),
                        signingCredentials: signIn);
                    var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);

                    return jwtToken;
                }
                else if (user !=null)
                {
                    var details = "Welcome " + user.UserName;
                    return (details);
                }
                else
                {
                    throw new Exception("User is not valid");
                }
            }
            else
            {
                throw new Exception("Credentials are not valid");
            }
        }
    }
}
