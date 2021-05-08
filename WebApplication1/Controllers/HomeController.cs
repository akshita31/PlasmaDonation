using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly DonorDBContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(
            DonorDBContext context,
            ILogger<HomeController> logger)
        {
            _context = context;
            _context.Database.EnsureCreated();
            _logger = logger;
        }

        public IActionResult Index()
        {            
            _context.Donors.AddRange(
                    new Models.Donor()
                    {
                        Name = "Neev Shah",
                        ContactNumber = "12445",
                    }
                );

            _context.SaveChanges();
            return View();
        }

        public IActionResult FindDonors()
        {
            return View();
        }

        public IActionResult RegisterAsDonor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterAsDonor(Donor donor)
        {
            Console.WriteLine(donor.Name);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
