using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class Package
    {
        public int PackageId { get; set; }
        [Required, StringLength(50), Display(Name = "Package Name")]
        public string PackageName { get; set; } = default!;
        [Required, Display(Name = "Package Price")]
        public decimal PackagePrice { get; set; }
        [Required, Display(Name = "Package Type")]
        public string PackageType { get; set; } = default!;
        public virtual ICollection<Billing>? Billings { get; set; }
        public virtual ICollection<User>? Users { get; set; }

    }
}
