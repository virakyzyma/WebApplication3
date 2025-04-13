using System.Text.RegularExpressions;

namespace WebApplication3.Services.Slugify
{
	public interface ISlugifyService
	{
		 string GenerateSlug(string phrase);

		 string Transliterate(string txt);
	}
}
