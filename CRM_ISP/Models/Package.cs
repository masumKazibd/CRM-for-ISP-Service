using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class Package
    {
        public Package()
        {
            this.Billings = new List<Billing>();
            this.UserPackages = new List<UserPackage>();
        }
        public int PackageId { get; set; }
        [Required, StringLength(50), Display(Name = "Package Name")]
        public string PackageName { get; set; } = default!;
        [Required, Display(Name = "Package Price")]
        public decimal PackagePrice { get; set; }
        [Required, Display(Name = "Package Type")]
        public string PackageType { get; set; } = default!;
        public int PackageDuration { get; set; }


        public virtual ICollection<Billing>? Billings { get; set; }
        public virtual ICollection<UserPackage>? UserPackages { get; set; }
    }
}
