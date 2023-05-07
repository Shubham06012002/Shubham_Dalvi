using Microsoft.AspNetCore.Mvc;
using Shubham_Dalvi.Entities;
using Shubham_Dalvi.Models;
using Shubham_Dalvi.Models.Dto;
using System.Diagnostics;

namespace Shubham_Dalvi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BaseDbContext _baseDbContext;

        public HomeController(ILogger<HomeController> logger, BaseDbContext baseDbContext)
        {
            _logger = logger;
            _baseDbContext = baseDbContext;
        }

        public IActionResult Index()
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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PersonallInfoViewModels obj)
        {
            var data = new PersonalInfo
            {

                Email = obj.Email,
                Message = obj.Message,
                Name = obj.Name,
            };
            _baseDbContext.PersonalInfos.Add(data);
            _baseDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}