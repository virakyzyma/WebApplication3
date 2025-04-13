﻿using WebApplication3.Data;
using WebApplication3.Models;
using WebApplication3.Services.Storage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
	[Route("api/product")]
	[ApiController]
	public class ApiProductController(DataAccessor dataAccessor, IStorageService storageService) : ControllerBase
	{
		private readonly IStorageService _storageService = storageService;
		private readonly DataAccessor _dataAccessor = dataAccessor;

		[HttpGet("{id}")]
		public RestResponseModel ProductById(string id)
		{
			return new()
			{
				CacheLifetime = 86400,
				Description = "Product API: Product By Id",
				Meta = new()
				{
					{ "locale", "uk" },
					{ "dataType", "object" }
				},
				Data = _dataAccessor.ProductById(id)
			};
		}
	}
}
