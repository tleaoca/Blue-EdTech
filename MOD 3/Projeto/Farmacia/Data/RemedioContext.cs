using Farmacia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Data
{
    public class RemedioContext : DbContext
    {
        public RemedioContext(DbContextOptions<RemedioContext> options) : base (options)
        {

        }
        public DbSet<Remedio> Remedio { get; set; }

        public DbSet<Pedido> Pedido { get; set; }
    }
}
