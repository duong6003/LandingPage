using LandingPage.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingPage.Data.Tranfer.ViewModels.Campaigns
{
    public class CampaignDetailViewModel
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public Guid WinnerId { get; set; }
        [Required]
        public DateTime AwareDate { get; set; }
        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        public int GiftId { get; set; }
    }
}
