using LandingPage.Kernel.Commons;
using System;
using System.Collections.Generic;

#nullable disable

namespace LandingPage.Data.Entities
{
    public partial class CampaignDetail : DomainEntity<int>
    {
        public CampaignDetail(int campaignId, Guid winnerId, DateTime awareDate, 
            string phoneNumber, int giftId)
        {
            CampaignId = campaignId;
            WinnerId = winnerId;
            AwareDate = awareDate;
            PhoneNumber = phoneNumber;
            GiftId = giftId;
        }

        public int CampaignId { get; set; }
        public Guid WinnerId { get; set; }
        public DateTime AwareDate { get; set; }
        public string PhoneNumber { get; set; }
        public int GiftId { get; set; }

        public virtual Campaign Campaign { get; set; }
        public virtual Gift Gift { get; set; }
        public virtual User Winner { get; set; }
    }
}
