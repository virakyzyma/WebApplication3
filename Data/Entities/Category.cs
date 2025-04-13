﻿using System.Text.Json.Serialization;

namespace WebApplication3.Data.Entities
{
    public record Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string? ImagesCsv { get; set; }
        public string? Slug { get; set; }
        //[JsonIgnore]
        public List<Product> Products { get; set; } = [];
    }
}
