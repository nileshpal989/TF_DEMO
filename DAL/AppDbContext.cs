using CRUDCORE.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDCORE.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) :
       base(options)
        {
        }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Cust_Details> Cust_Details { get; set; }
        public virtual DbSet<EmpDetails> EmpDetails { get; set; }
    }
}
