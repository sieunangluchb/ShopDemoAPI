namespace ShopDemoAPI.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using ShopDemoAPI.Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopDemoAPI.Data.ShopDemoAPIDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopDemoAPI.Data.ShopDemoAPIDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            CreateProductCategory(context);

            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ShopDemoAPIDbContext()));
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ShopDemoAPIDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "NhatMinh",
            //    Email = "tinhyeuthienthan1@gmail.com",
            //    EmailConfirmed = true,
            //    BirthDay = DateTime.Now,
            //    FullName = "Võ Hoàng Nhật Minh"
            //};

            //manager.Create(user, "123456789");

            //if (!roleManager.Roles.Any()) {
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("tinhyeuthienthan1@gmail.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }

        private void CreateProductCategory(ShopDemoAPIDbContext context)
        {
            if (context.PRODUCTCATEGORYs.Count() == 0)
            {
                List<PRODUCTCATEGORY> lstProductCategory = new List<PRODUCTCATEGORY>() {
                new PRODUCTCATEGORY(){ NAME = "Điện lạnh", ALIAS = "dien-lanh", STATUS=true},
                new PRODUCTCATEGORY(){ NAME = "Viện thông", ALIAS = "vien-thong", STATUS=true},
                new PRODUCTCATEGORY(){ NAME = "Đồ gia dụng", ALIAS = "do-gia-dung", STATUS=true},
                new PRODUCTCATEGORY(){ NAME = "Mỹ phẩm", ALIAS = "my-pham",STATUS=true}
            };
                context.PRODUCTCATEGORYs.AddRange(lstProductCategory);
                context.SaveChanges();
            }
        }
    }
}
