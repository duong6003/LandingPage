using System;
using System.ComponentModel.DataAnnotations;

namespace LandingPage.Data.Tranfer.ViewModels.Campaigns
{
    public class CampaignViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public int RuleId { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

        [Required]
        public DateTime DateEnd { get; set; }

        [Required]
        public string Status { get; set; }
    }
}