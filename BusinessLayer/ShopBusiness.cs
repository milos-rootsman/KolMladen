using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class ShopBusiness : IShopBusiness
    {
        ShopItemRepository shopRepository;

        public ShopBusiness()
        {
            shopRepository = new ShopItemRepository();
        }

        public bool Delete(int shopItemId)
        {
            return shopRepository.Delete(shopItemId);
        }

        public List<ShopItem> GetAll()
        {
            return shopRepository.GetAll();
        }

        public ShopItem GetById(int id)
        {
            return shopRepository.GetAll().Where(tmp => tmp.Id == id).First();
        }

        public bool Insert(ShopItem shopItem)
        {
            return shopRepository.Insert(shopItem);
        }

        public bool Update(ShopItem shopItem)
        {
            return shopRepository.Update(shopItem);
        }
    }
}
