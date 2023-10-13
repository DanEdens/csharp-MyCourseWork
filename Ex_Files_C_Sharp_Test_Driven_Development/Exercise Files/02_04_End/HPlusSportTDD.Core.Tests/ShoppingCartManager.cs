using System;

namespace HPlusSportTDD.Core
{
    internal class ShoppingCartManager
    {
        public ShoppingCartManager()
        {
        }

        internal AddToCartResponse AddToCart(AddToCartRequest request)
        {
            return new AddToCartResponse()
            {
                Items = new AddToCartItem[] { request.Item }
            };
        }
    }
}