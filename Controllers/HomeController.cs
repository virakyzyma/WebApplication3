using WebApplication3.Data;
using WebApplication3.Models;
using WebApplication3.Services.Hash;
using WebApplication3.Services.Kdf;
using WebApplication3.Services.Random;
using WebApplication3.Services.Time;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRandomService _randomService;
        private readonly IHashService _md5HashService;
        private readonly ITimeService _timeService;
        private readonly DataContext _dataContext;
        private readonly IKdfService _kdfService;

        public HomeController(ILogger<HomeController> logger,
            IRandomService randomService,
            IHashService md5HashService,
            ITimeService timeService,
            DataContext dataContext,
            IKdfService kdfService)
        {
            _logger = logger;
            _randomService = randomService;
            _md5HashService = md5HashService;
            _timeService = timeService;
            _dataContext = dataContext;
            _kdfService = kdfService;
        }

        public IActionResult Index()
        {
            ViewData["path"] = Directory.GetCurrentDirectory();
            return View();
        }

        public IActionResult Introduction()
        {
            return View();
        }
        public IActionResult Homeworks()
        {
            ViewData["pbkdf1_pass1"] = _kdfService.Dk("1234", "6x91", 10000, 32);
            ViewData["pbkdf1_pass2"] = _kdfService.Dk("jdsa123Vjsda3", "8as12", 10000, 32);
            return View();
        }
        public IActionResult IoC()
        {
            // ViewData - ��'��� ��� �������� ����� �� ���������� �� �������������
            ViewData["_randomService"] = _randomService;
            ViewData["md5Hash"] = _md5HashService.Digest("123");
            return View();
        }
        public IActionResult Razor()
        {
            return View();
        }
        public IActionResult Db()
        {
            ViewData["db-info"] = $"Users: {_dataContext.Users.Count()}, Accesses: {_dataContext.Accesses.Count()}";
            return View();
        }
		public IActionResult Rest()
		{
			return View();
		}
		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
