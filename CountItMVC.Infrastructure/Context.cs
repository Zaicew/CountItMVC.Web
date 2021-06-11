using System;
using System.Collections.Generic;
using System.Text;
using CountItMVC.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CountItMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<ContactDetailType> ContactDetailTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerContactInformation> CustomerContactInformations { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemInMeal> ItemInMeals { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<CategoryTag> CategoryTag { get; set; }
        public DbSet<DayTag> DayTag { get; set; }
        public DbSet<ItemTag> ItemTag { get; set; }
        public DbSet<MealDay> MealsDay { get; set; }



        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //(1)organization relation 1vs1
            builder.Entity<Customer>()
                .HasOne(a => a.CustomerContactInformation).WithOne(b => b.Customer)
                .HasForeignKey<CustomerContactInformation>(e => e.CustomerRef);



            //many vs many relations 

            //meals vs days
            builder.Entity<MealDay>()
                .HasKey(it => new { it.MealId, it.DayID });
            builder.Entity<MealDay>()
                .HasOne<Meal>(it => it.Meal)
                .WithMany(i => i.MealsDays)
                .HasForeignKey(it => it.MealId);
            builder.Entity<MealDay>()
                .HasOne<Day>(it => it.Day)
                .WithMany(i => i.MealsDays)
                .HasForeignKey(it => it.DayID);

            // items in meal 
            builder.Entity<ItemInMeal>()
                .HasKey(it => new { it.MealId, it.ItemId });
            builder.Entity<ItemInMeal>()
                .HasOne<Meal>(it => it.Meal)
                .WithMany(i => i.ItemsInMeals)
                .HasForeignKey(it => it.MealId);
            builder.Entity<ItemInMeal>()
                .HasOne<Item>(it => it.Item)
                .WithMany(i => i.ItemsInMeals)
                .HasForeignKey(it => it.ItemId);


            //itemtag
            builder.Entity<ItemTag>()
                .HasKey(it => new {it.ItemId, it.TagId});
            builder.Entity<ItemTag>()
                .HasOne<Item>(it => it.Item)
                .WithMany(i => i.ItemsTags)
                .HasForeignKey(it => it.ItemId);
            builder.Entity<ItemTag>()
                .HasOne<Tag>(it => it.Tag)
                .WithMany(i => i.ItemsTags)
                .HasForeignKey(it => it.TagId);

            //daytag
            builder.Entity<DayTag>()
                .HasKey(it => new {it.DayId, it.TagId});
            builder.Entity<DayTag>()
                .HasOne<Day>(it => it.Day)
                .WithMany(i => i.DaysTags)
                .HasForeignKey(it => it.DayId);
            builder.Entity<DayTag>()
                .HasOne<Tag>(it => it.Tag)
                .WithMany(i => i.DaysTags)
                .HasForeignKey(it => it.TagId);

            //categorytag
            builder.Entity<CategoryTag>()
                .HasKey(it => new {it.CategoryId, it.TagId});
            builder.Entity<CategoryTag>()
                .HasOne<Category>(it => it.Category)
                .WithMany(i => i.CategoriesTags)
                .HasForeignKey(it => it.CategoryId);
            builder.Entity<CategoryTag>()
                .HasOne<Tag>(it => it.Tag)
                .WithMany(i => i.CategoriesTags)
                .HasForeignKey(it => it.TagId);
        }
    }
}
