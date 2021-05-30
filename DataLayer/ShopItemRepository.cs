using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class ShopItemRepository : IShopItemsRepository
    {
        KolokvijumContext context;

        public ShopItemRepository()
        {
            this.context = new KolokvijumContext();
        }

        public bool Delete(int shopItemId)
        {
            ShopItem si = this.context.ShopItems.Find(shopItemId);
            this.context.ShopItems.Remove(si);
            return this.context.SaveChanges() != 0;
        }

        public List<ShopItem> GetAll()
        {
            return this.context.ShopItems.ToList();
        }

        public bool Insert(ShopItem shopItem)
        {
            this.context.ShopItems.Add(shopItem);
            return this.context.SaveChanges() != 0;
        }

        public bool Update(ShopItem shopItem)
        {
            this.context.ShopItems.Update(shopItem);
            return this.context.SaveChanges() != 0;
        }
    }
}
