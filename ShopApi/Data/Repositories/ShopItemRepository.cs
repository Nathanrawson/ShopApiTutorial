using ShopApi.Data;
using ShopApi.Data.EntityModels;
using ShopApi.Data.Repositories.Interfaces;

namespace ShopApi.Data.Repositories
{
    public class ShopItemRepository : BaseRepository<ShopItem>, IShopItemRepository
    {
        public ShopItemRepository(ShopContext shopContext) : base(shopContext)
        {

        }
    }
}
