using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealHomeProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.DataAccess.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(true).
                ConfigureWarnings(x=> x.Ignore());
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; " +
                "Database = RealHomeProjectDB;" +
                " Integrated Security=True; Trust Server Certificate=True");
        }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<CompanyService> CompanyServices { get; set; }
        public DbSet<OurPartner> OurPartner { get; set; }
        public DbSet<PopularRentHome> PopularRentHome { get; set; }
        public DbSet<PrivacyPolicy> PrivacyPolicies { get; set; }
        public DbSet<TermAndCondition> TermAndConditions { get; set; }  
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<WhyChooseUs> WhyChooseUs { get; set;}
        public DbSet<Dealer> Dealers { get; set; }  
    }
}
