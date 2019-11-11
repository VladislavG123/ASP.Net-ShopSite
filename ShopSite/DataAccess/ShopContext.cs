using ShopSite.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace ShopSite.DataAccess
{

    public class ShopContext : DbContext
    {
        public ShopContext()
            : base("name=ShopContext")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}