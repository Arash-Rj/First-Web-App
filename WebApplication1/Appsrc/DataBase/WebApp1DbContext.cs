using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Appsrc.DataBase
{
    public class WebApp1DbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-7648UU0\SQLEXPRESS; Initial Catalog=WebApp1; User Id=sa; Password=123456; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<User> users { get; set; }  
    }
}
