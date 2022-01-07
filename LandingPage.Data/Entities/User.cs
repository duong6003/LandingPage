using LandingPage.Kernel.Commons;
using System;
using System.Collections.Generic;

#nullable disable

namespace LandingPage.Data.Entities
{
    public partial class User : DomainEntity<Guid>
    {
        public User()
        {
            CampaignDetails = new HashSet<CampaignDetail>();
            RefreshTokens = new HashSet<RefreshToken>();
        }

        public User(string fullName, string phoneNumber, 
            DateTime? birthDay, int? positionId, 
            int? businessTypeId, string passwordHash, 
            string userName)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            BirthDay = birthDay;
            PositionId = positionId;
            BusinessTypeId = businessTypeId;
            PasswordHash = passwordHash;
            UserName = userName;
        }

        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDay { get; set; }
        public int? PositionId { get; set; }
        public int? BusinessTypeId { get; set; }
        public string PasswordHash { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<CampaignDetail> CampaignDetails { get; set; }
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}
