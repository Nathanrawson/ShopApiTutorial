using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using ShopApi.Data.EntityModels;
using ShopApi.Data.Repositories.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IBaseRepository<ShopItem> _shopData;

        public ShopController(IShopItemRepository shopData)
        {
            _shopData = shopData;
        }

        // GET: /<ShopController>
        [HttpGet]
        public IEnumerable<ShopItem> Get()
        {
            return _shopData.GetAll();
        }

        // GET /<ShopController>/5
        [HttpGet("{id}")]
        public ShopItem Get(Guid id)
        {
            return _shopData.GetById(id);
        }

        // POST /<ShopController>
        [HttpPost]
        public void Post([FromBody] ShopItem shopItem)
        {
            _shopData.Add(shopItem);
        }

        // PUT /<ShopController>
        [HttpPut]
        public void Put([FromBody] ShopItem shopItem)
        {
            _shopData.Update(shopItem);
        }

        // DELETE /<ShopController>/5
        [HttpDelete("{id}")]
        public void Delete([FromRoute] Guid id)
        {
            _shopData.Delete(id);
        }
    }
}
