using WebApplication3.Data.Entities;

namespace WebApplication3.Models.Shop
{
	public class ShopProductPageModel
	{
		public Product? Product { get; set; }
		public Category[] Categories { get; set; } = [];
		public bool IsUserCanRate {  get; set; }
		public Rate? UserRate { get; set; }
		public string? AuthUserId { get; set; }
	}
}
