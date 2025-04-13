﻿using WebApplication3.Services.Storage;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class StorageController(IStorageService storageService) : Controller
    {
        private readonly IStorageService _storageService = storageService;
        public IActionResult Item([FromRoute] string id)
        {
            Stream? fileStream = _storageService.Get(id);
            if (fileStream is null) 
            {
                return NotFound();
            }
            return File(fileStream, "image/jpeg");
        }
    }
}
