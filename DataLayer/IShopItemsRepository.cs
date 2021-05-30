using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public interface IShopItemsRepository
    {
        public List<ShopItem> GetAll();
        public bool Insert(ShopItem shopItem);
        public bool Update(ShopItem shopItem);
        public bool Delete(int shopItemId);
    }
}
