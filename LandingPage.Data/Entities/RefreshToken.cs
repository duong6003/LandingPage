using LandingPage.Kernel.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LandingPage.Data.Entities
{
    public partial class RefreshToken : DomainEntity<Guid>
    {
        [Required]
        public string Token { get; set; }
        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}
