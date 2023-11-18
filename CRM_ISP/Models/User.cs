using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_ISP.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required, Display(Name = "User Name")]
        public string UserName { get; set; } = default!;
        [Required, Display(Name = "Email")]
        public string UserEmail { get; set; } = default!;
        [Required, Display(Name = "Password")]
        public string UserPassword { get; set; } = default!;
        [Required, Display(Name = "Phone")]
        public string UserPhone { get; set; } = default!;
        [Required, Display(Name = "Gender")]
        public string UserGender { get; set; } = default!;
        [Required, Display(Name = "User Image")]
        public string UserImage { get; set; } = default!;
        [Required, Display(Name = "User Address")]
        public string UserAddress { get; set; } = default!;
        [Display(Name = "User Created Date")]
        public DateTime UserCreateDate { get; set; } = DateTime.Now;

        //Foreign Key
        [ForeignKey("City")]
        public int CityId { get; set; }
        [ForeignKey("Area")]
        public int AreaId { get; set; }
        [ForeignKey("Package")]
        public int PackageId { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public virtual City? City { get; set; }
        public virtual Area? Area { get; set; }
        public virtual Package? Package { get; set; }
        public virtual Role? Role { get; set; }
        

        public virtual ICollection<Billing>? Billings { get; set; }
        public virtual ICollection<Complain>? Complains { get; set; }
        public virtual ICollection<Feedback>? Feedbacks { get; set; }
    }
}
