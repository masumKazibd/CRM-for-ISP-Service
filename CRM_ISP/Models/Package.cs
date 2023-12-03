using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class Package
    {
        public int PackageId { get; set; }
        [Required(ErrorMessage = "Package name is required"), StringLength(60), Display(Name = "Package Name")]

        public string PackageName { get; set; } = null!;
        [Required(ErrorMessage = "Package price is required"), Display(Name = "Package Price")]

        public decimal PackagePrice { get; set; }
        [Required(ErrorMessage = "Package type is required"), StringLength(60), Display(Name = "Package Type")]

        public string PackageType { get; set; } = null!;
        [Required(ErrorMessage = "Please type package duration"), Display(Name = "Package Duration")]

        public int PackageDuration { get; set; }

        public virtual ICollection<Billing>? Billings { get; set; } = new List<Billing>();

        public virtual ICollection<UserComplain>? UserComplains { get; set; } = new List<UserComplain>();

        public virtual ICollection<User>? Users { get; set; } = new List<User>();
    }
}
