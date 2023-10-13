using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPlusSportTDD.Core
{
    public interface IShoppingCartManager
    {
        public AddToCartResponse AddToCart(AddToCartRequest request);
        public IEnumerable<AddToCartItem> GetCart();
    }
}
