using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesMvc.Models;
using SalesMvc.Data;

namespace SalesMvc.Data
{
    public class SalesMvcContext : DbContext
    {
        public SalesMvcContext (DbContextOptions<SalesMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord>  SalesRecord { get; set; }
    }
}
