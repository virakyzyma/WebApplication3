using WebApplication3.Data;
using WebApplication3.Data.Entities;
using WebApplication3.Models;
using WebApplication3.Models.Shop;
using WebApplication3.Services.Storage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Controllers
{
	[Route("api/category")]
	[ApiController]
	public class ApiCategoryController(DataAccessor dataAccessor, IStorageService storageService) : ControllerBase
	{
		private readonly IStorageService _storageService = storageService;
		private readonly DataAccessor _dataAccessor = dataAccessor;
		[HttpGet]
		public RestResponseModel CategoriesList()
		{
			return new()
			{
				CacheLifetime = 86400,
				Description = "Product Category API: Categories List",
				Manipulations = new()
				{
					Read = "api/category/{id}"
				},
				Meta = new()
				{
					{ "locale", "uk" },
					{ "dataType", "object" }
				},
				Data = _dataAccessor.CategoriesList()
			};
		}
		[HttpGet("{id}")]
		public RestResponseModel CategoryById(string id)
		{
			return new()
			{
				CacheLifetime = 86400,
				Description = "Product Category API: Category By Id",
				Meta = new()
				{
					{ "locale", "uk" },
					{ "dataType", "object" }
				},
				Data = _dataAccessor.CategoryById(id)
			};
		}
		/*[HttpGet("{id}")]
		public RestResponseModel ProductById(string id)
		{

		}*/
	}
}
