using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_ISP.Models
{
    public class User
    {
        public int UserId { get; set; }
        // [Required(ErrorMessage = "User Name is required"), Display(Name = "User Name"), StringLength(50)]

        public string UserName { get; set; } = null!;
        //[Required(ErrorMessage = "User Email is required"), Display(Name = "User Email"), StringLength(50)]

        public string UserEmail { get; set; } = null!;
        // [Required(ErrorMessage = " Password is required"), Display(Name = "User Password"), StringLength(20)]

        public string UserPassword { get; set; } = null!;

        // [Required(ErrorMessage = " Phone number is required"), Display(Name = "User Phone"), StringLength(15)]
        public string UserPhone { get; set; } = null!;

        //[Required(ErrorMessage = " Gender is required"), Display(Name = "User Gender")]
        public string UserGender { get; set; } = null!;

        // [Required(ErrorMessage = " Image is required"), Display(Name = "User Image")]
        public string? UserImage { get; set; } = null!;

        // [Required(ErrorMessage = "User Address is required"), Display(Name = "User Address"), StringLength(50)]
        public string UserAddress { get; set; } = null!;
        //[Required(ErrorMessage = "CreateDate is required")]
        [ Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true), Display(Name = "Create Date")]
        public DateTime UserCreateDate { get; set; } = DateTime.Now;

        [ForeignKey("City")]
        public int? CityId { get; set; }

        [ForeignKey("Area")]
        public int? AreaId { get; set; }
        [ForeignKey("Package")]
        public int? PackageId { get; set; }
        [ForeignKey("Role")]
        public int? RoleId { get; set; }

        public virtual Area? Area { get; set; }

        public virtual ICollection<Billing>? Billings { get; set; } = new List<Billing>();

        public virtual City? City { get; set; }

        public virtual ICollection<Feedback>? FeedBacks { get; set; } = new List<Feedback>();

        public virtual Package? Package { get; set; }

        public virtual Role? Role { get; set; }

        public virtual ICollection<UserComplain>? UserComplains { get; set; } = new List<UserComplain>();
    }



}
