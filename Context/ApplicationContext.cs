using Dota2App.DAL.Item;
using Dota2App.Models;
using Microsoft.EntityFrameworkCore;

namespace Dota2App.Context
{
    public class ApplicationContext : DbContext
    {   
        public DbSet<HeroModel> Heroes { get; set; }
        public DbSet<ItemModel> Items { get; set; }
        public DbSet<ItemAttribute> ItemAttribute { get; set; }
        public DbSet<ItemAttributeValue> ItemAttributeValue { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public ApplicationContext() : base() { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ItemModel>()
        //        .HasMany(c => c.AttributeBonuses)
        //        .WithOne(e => e.ItemModel)
        //        .OnDelete(DeleteBehavior.Cascade);
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
