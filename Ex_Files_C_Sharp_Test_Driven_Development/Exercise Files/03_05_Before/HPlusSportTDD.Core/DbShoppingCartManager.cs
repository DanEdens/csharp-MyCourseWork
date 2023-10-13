using System;
using System.Collections.Generic;
using System.Linq;

namespace HPlusSportTDD.Core
{
    public class DbShoppingCartManager : IShoppingCartManager
    {
        private readonly ShoppingCartContext _db;

        public DbShoppingCartManager(ShoppingCartContext context)
        {
            this._db = context;
        }

        public AddToCartResponse AddToCart(AddToCartRequest request)
        {
            var item = _db.Items.FirstOrDefault(i => i.ArticleId == request.Item.ArticleId);
            if (item != null)
            {
                item.Quantity += request.Item.Quantity;
            }
            else
            {
                _db.Items.Add(request.Item);
            }
            _db.SaveChanges();

            return new AddToCartResponse()
            {
                Items = _db.Items.ToArray()
            };
        }

        public IEnumerable<AddToCartItem> GetCart()
        {
            return this._db.Items.ToList();
        }
    }
}