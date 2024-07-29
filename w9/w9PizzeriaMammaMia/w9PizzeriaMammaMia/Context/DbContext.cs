using Microsoft.EntityFrameworkCore;
using w9PizzeriaMammaMia.Models;

namespace w9PizzeriaMammaMia.Context

{
    public class DataContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Utenti> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        public DataContext(DbContextOptions<DataContext> opt) : base(opt) { }
    }
}