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
            return View();
        }

        public IActionResult FindDonors()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FindDonors(FindDonorsViewModel viewModel)
        {
            var donors = _context.Donors.Where
                (donor => donor.BloodGroup == viewModel.BloodGroup);
            
            return View(new FindDonorsViewModel()
            {
                BloodGroup = viewModel.BloodGroup,
                Donors = donors.ToList()
            });
        }

        public IActionResult RegisterAsDonor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterAsDonor(Donor donor)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine(donor.Name);
                _context.Donors.AddRange(donor);
                _context.SaveChanges();
            }
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
