using Microsoft.AspNet.Identity.EntityFramework;
using ShopDemoAPI.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Data
{
    public class ShopDemoAPIDbContext : IdentityDbContext<ApplicationUser>
    {
        public ShopDemoAPIDbContext() : base("ShopDemoAPIConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<FOOTER> FOOTERs { get; set; }
        public DbSet<MENU> MENUs { get; set; }
        public DbSet<MENUGROUP> MENUGROUPs { get; set; }
        public DbSet<ORDER> ORDERs { get; set; }
        public DbSet<ORDERDETAIL> ORDERDETAILs { get; set; }
        public DbSet<PAGE> PAGEs { get; set; }
        public DbSet<POST> POSTs { get; set; }
        public DbSet<POSTCATEGORY> POSTCATEGORYs { get; set; }
        public DbSet<POSTTAG> POSTTAGs { get; set; }
        public DbSet<PRODUCT> PRODUCTs { get; set; }
        public DbSet<PRODUCTCATEGORY> PRODUCTCATEGORYs { get; set; }
        public DbSet<PRODUCTTAG> PRODUCTTAGs { get; set; }
        public DbSet<SLIDE> SLIDEs { get; set; }
        public DbSet<SUPPORTONLINE> SUPPORTONLINEs { get; set; }
        public DbSet<SYSTEMCONFIG> SYSTEMCONFIGs { get; set; }
        public DbSet<TAG> TAGs { get; set; }
        public DbSet<VISITORSTATISTIC> VISITORSTATISTICs { get; set; }
        public DbSet<ERROR> ERRORs { get; set; }

        public static ShopDemoAPIDbContext Create()
        {
            return new ShopDemoAPIDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
            modelBuilder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }
    }
}
