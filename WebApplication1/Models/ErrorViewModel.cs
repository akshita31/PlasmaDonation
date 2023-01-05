using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class FindDonorsViewModel
    {
        public BloodGroup BloodGroup { get; set; }

        public List<Donor> Donors { get; set; }
    }
}
