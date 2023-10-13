using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPlusSportTDD.Core
{
    public class ShoppingCartContext : DbContext
    {

        public ShoppingCartContext() : base()
        {
        }
        public ShoppingCartContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<AddToCartItem> Items { get; set; }
        public virtual DbSet<ShoppingCart> Carts { get; set; }
    }
}
