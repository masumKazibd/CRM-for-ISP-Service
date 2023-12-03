namespace CRM_ISP.Models
{
    public class AddUserRole
    {
        public int AddUserRoleId { get; set; }
        public int UserId { get; set; }

        public List<int> RoleIds { get; set; }
    }
}
