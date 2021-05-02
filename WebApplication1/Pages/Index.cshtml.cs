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
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Data.DonorContext _context;

        public IndexModel(WebApplication1.Data.DonorContext context)
        {
            _context = context;
        }

        public IList<Donor> Donor { get;set; }

        public async Task OnGetAsync()
        {
            Donor = await _context.Donor.ToListAsync();
        }
    }
}
