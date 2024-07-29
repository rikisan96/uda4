using Microsoft.EntityFrameworkCore;
using W9.InTheOven.Models;

namespace w9PizzeriaMammaMia.Context

{
    public class DataContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        public DataContext(DbContextOptions<DataContext> opt) : base(opt) { }
    }
}