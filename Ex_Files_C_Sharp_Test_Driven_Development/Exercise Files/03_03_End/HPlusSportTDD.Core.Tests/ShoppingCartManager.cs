using System;
using System.Collections.Generic;

namespace HPlusSportTDD.Core
{
    public class ShoppingCartManager : IShoppingCartManager
    {
        private List<AddToCartItem> _shoppingCart;

        public ShoppingCartManager()
        {
            _shoppingCart = new List<AddToCartItem>();
        }

        public AddToCartResponse AddToCart(AddToCartRequest request)
        {
            var item = _shoppingCart.Find(i => i.ArticleId == request.Item.ArticleId);
            if (item != null)
            {
                item.Quantity += request.Item.Quantity;
            }
            else
            {
                _shoppingCart.Add(request.Item);
            }

            return new AddToCartResponse()
            {
                Items = _shoppingCart.ToArray()
            };
        }

        public AddToCartItem[] GetCart()
        {
            return _shoppingCart.ToArray();
        }
    }
}