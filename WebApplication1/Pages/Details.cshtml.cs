using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication1.Data.DonorContext _context;

        public DetailsModel(WebApplication1.Data.DonorContext context)
        {
            _context = context;
        }

        public Donor Donor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Donor = await _context.Donor.FirstOrDefaultAsync(m => m.Id == id);

            if (Donor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
