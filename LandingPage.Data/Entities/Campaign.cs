using LandingPage.Kernel.Commons;
using System;
using System.Collections.Generic;

#nullable disable

namespace LandingPage.Data.Entities
{
    public partial class Campaign : DomainEntity<int>
    {
        public Campaign()
        {
            CampaignDetails = new HashSet<CampaignDetail>();
            Gifts = new HashSet<Gift>();
        }

        public Campaign(string name, int ruleId, string description, DateTime dateStart, DateTime dateEnd, string status)
        {
            Name = name;
            RuleId = ruleId;
            Description = description;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Status = status;
        }

        public string Name { get; set; }
        public int RuleId { get; set; }
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Status { get; set; }

        public virtual Rule Rule { get; set; }
        public virtual ICollection<CampaignDetail> CampaignDetails { get; set; }
        public virtual ICollection<Gift> Gifts { get; set; }
    }
}
