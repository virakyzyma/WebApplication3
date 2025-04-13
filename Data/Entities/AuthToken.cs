﻿using System.Text.Json.Serialization;

namespace WebApplication3.Data.Entities
{
	public class AuthToken
	{
		public Guid Jti { get; set; }
		public string? Iss { get; set; }
		public Guid? Sub { get; set; }
		public string? Aud { get; set; }	
		public DateTime Iat { get; set; }
		public DateTime Exp { get; set; }
		public DateTime? Nbf { get; set; }

		[JsonIgnore]
		public UserAccess UserAccess { get; set; }
	}
}
