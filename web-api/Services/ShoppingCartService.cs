using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api.Interfaces;
using web_api.Models;

namespace web_api.Services
{
    public class ShoppingCartService: IShoppingCartService
    {
        public ShoppingItem Add(ShoppingItem newItem)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<ShoppingItem> GetAllItems()
        {
            throw new NotImplementedException();
        }
        public ShoppingItem GetById(Guid id)
        {
            throw new NotImplementedException();
        }
        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
