using ShopApi.Data.EntityModels.Interfaces;

namespace ShopApi.Data.EntityModels
{
    public class ShopItem: IBaseEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public DateTime Created { get; set; }
    }
}
