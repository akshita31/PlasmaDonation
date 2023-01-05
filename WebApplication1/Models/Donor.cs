using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Donor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        [Required]
        public BloodGroup BloodGroup { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        [Display(Name = "No. of days from Covid recovery")]
        public int DaysFromCovidRecovery { get; set; }

        [Display(Name="Disease if any")]
        public string Disease { get; set; }

        public DateTime SubmittedTimestamp { get; set; } = DateTime.Now;
    }

    public enum Gender
    {
        Female,
        Male,
        Other
    }
}
