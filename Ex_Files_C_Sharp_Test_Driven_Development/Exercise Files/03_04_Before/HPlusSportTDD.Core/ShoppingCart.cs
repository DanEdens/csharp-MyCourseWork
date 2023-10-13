using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPlusSportTDD.Core
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public virtual List<AddToCartItem> Items { get; set; }
    }
}
