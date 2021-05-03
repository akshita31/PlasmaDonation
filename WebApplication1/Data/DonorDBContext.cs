using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DonorDBContext : DbContext
    {
        public DonorDBContext (DbContextOptions<DonorDBContext> options)
            : base(options)
        {
        }

        public DbSet<Donor> Donors { get; set; }
    }
}
