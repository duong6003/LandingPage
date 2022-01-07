using LandingPage.Kernel.Commons;
using System;
using System.Collections.Generic;

#nullable disable

namespace LandingPage.Data.Entities
{
    public partial class Gift : DomainEntity<int>
    {
        public Gift()
        {
            CampaignDetails = new HashSet<CampaignDetail>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int CampaignId { get; set; }
        public bool IsRepresentation { get; set; }
        public string Status { get; set; }

        public virtual Campaign Campaign { get; set; }
        public virtual ICollection<CampaignDetail> CampaignDetails { get; set; }
    }
}
