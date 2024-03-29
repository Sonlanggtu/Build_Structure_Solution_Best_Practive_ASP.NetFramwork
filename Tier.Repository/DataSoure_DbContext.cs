﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tier.Model.Models;

namespace Tier.Repository
{
   public class DataSoure_DbContext : IdentityDbContext<ApplicationUser>
    {
        public DataSoure_DbContext() : base("DBConnection", throwIfV1Schema: false)
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

       // public DbSet<ApplicationUser> ApplicationUsers { set; get; }

        public DbSet<Error> Errors { set; get; }

        public DbSet<Footer> Footers { set; get; }

        public DbSet<Menu> Menus { set; get; }

        public DbSet<MenuGroup> MenuGroups { set; get; }

        public DbSet<Order> Orders { set; get; }

        public DbSet<OrderDetail> OrderDetails { set; get; }

        public DbSet<Page> Pages { get; set; }

        public DbSet<Post> Posts { set; get; }

        public DbSet<ProductCategory> ProductCategories { set; get; }

        public DbSet<PostTag> PostTags { set; get; }

        public DbSet<Product> Products { set; get; }

        public DbSet<PostCategory> PostCategories { set; get; }

        public DbSet<ProductTag> ProductTags { set; get; }

        public DbSet<Slide> Slides { set; get; }

        public DbSet<SupportOnline> SupportOnlines { set; get; }

        public DbSet<SystemConfig> SystemConfigs { set; get; }

        public DbSet<Tag> Tags { set; get; }

        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }



        public static DataSoure_DbContext Create()
        {
            return new DataSoure_DbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {

              builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
              builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }

    }
}
