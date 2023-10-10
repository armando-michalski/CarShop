using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarShop.Models;

namespace CarShop.Data
{
    public class CarShopContext : DbContext
    {
        public CarShopContext (DbContextOptions<CarShopContext> options)
            : base(options)
        {
        }

        public DbSet<CarShop.Models.Car> Car { get; set; } = default!;

        public DbSet<CarShop.Models.Client>? Client { get; set; }

        public DbSet<CarShop.Models.Seller>? Seller { get; set; }

        public DbSet<CarShop.Models.Note>? Note { get; set; }
    }
}
