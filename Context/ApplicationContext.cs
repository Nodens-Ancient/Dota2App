using Dota2App.Models;
using Microsoft.EntityFrameworkCore;

namespace Dota2App.Context
{
    public class ApplicationContext : DbContext
    {   
        public DbSet<HeroModel> Heroes { get; set; }
        public DbSet<ItemModel> Items { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public ApplicationContext() : base() { }
    }
}
