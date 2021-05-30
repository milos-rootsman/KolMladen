using BusinessLayer;
using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MladenPedercina.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopItemsController : ControllerBase
    {
        ShopBusiness sb;
        public ShopItemsController()
        {
            sb = new ShopBusiness();
        }

        // GET: api/<ShopItemsController>
        [HttpGet]
        public List<ShopItem> Get()
        {
            return sb.GetAll();
        }

        // GET api/<ShopItemsController>/5
        [HttpGet("{id}")]
        public ShopItem Get(int id)
        {
            return sb.GetById(id);
        }

        // POST api/<ShopItemsController>
        [HttpPost]
        public bool Post(ShopItem si)
        {
            return sb.Insert(si);
        }

        // PUT api/<ShopItemsController>/5
        [HttpPut]
        public bool Put(ShopItem si)
        {
            return sb.Update(si);
        }

        // DELETE api/<ShopItemsController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return sb.Delete(id);
        }
    }
}
