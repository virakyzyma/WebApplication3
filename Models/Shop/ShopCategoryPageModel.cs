using WebApplication3.Data.Entities;

namespace WebApplication3.Models.Shop
{
    public class ShopCategoryPageModel
    {
        public Data.Entities.Category? Category { get; set; }
		public Category[] Categories { get; set; } = [];
	}
}
