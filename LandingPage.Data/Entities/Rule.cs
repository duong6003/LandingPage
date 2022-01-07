using LandingPage.Kernel.Commons;
using System;
using System.Collections.Generic;

#nullable disable

namespace LandingPage.Data.Entities
{
    public partial class Rule : DomainEntity<int>
    {
        public Rule()
        {
            Campaigns = new HashSet<Campaign>();
        }

        public string Content { get; set; }

        public virtual ICollection<Campaign> Campaigns { get; set; }
    }
}
