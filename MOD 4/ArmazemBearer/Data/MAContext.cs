using Armazem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Armazem.Data
{
    public class MAContext : IdentityDbContext
    {
        public MAContext(DbContextOptions<MAContext> options) : base(options) { }
        public DbSet<Product> Product { get; set; }
    }
}
