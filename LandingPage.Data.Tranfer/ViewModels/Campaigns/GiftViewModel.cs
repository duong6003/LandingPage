using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingPage.Data.Tranfer.ViewModels.Campaigns
{
    public class GiftViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int CampaignId { get; set; }
        public bool IsRepresentation { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
