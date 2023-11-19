using Microsoft.EntityFrameworkCore;

namespace CRM_ISP.Models
{
    public class CrmDbContext:DbContext
    {
        public CrmDbContext(DbContextOptions<CrmDbContext> options):base(options) { }
        

        public DbSet<Admin>? Admins { get; set; }
        public DbSet<Area>? Areas { get; set; }
        public DbSet<Billing>? Billings { get; set; }    
        public DbSet<City>? Cities { get; set; }
        public DbSet<Complain>? Complaines { get; set; }
        public DbSet<ComplainStatus>? ComplainesStatuses { get; set;}
        public DbSet<Feedback >? Feedbacks { get; set; } 
        public DbSet<Package>? Packages { get; set; }
        public DbSet<RegistrationMessage>? RegistrationMessages { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<SupportEngineer>? SupportEngineers { get; set; }
        public DbSet<User>?  Users { get; set; }
        public DbSet<UserPackage>? UsersPackages { get; set; }


    }
}
