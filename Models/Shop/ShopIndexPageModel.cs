using WebApplication3.Data.Entities;

namespace WebApplication3.Models.Shop
{
    public class ShopIndexPageModel
    {
        public List<Category> Categories { get; set; } = [];
		public bool? CanCreate { get; set; }
		public bool? ValidationStatus { get; set; }
		public Dictionary<string, string>? Errors { get; set; }
	}
}
