using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingPage.Data.Tranfer.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }
        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        public DateTime? BirthDay { get; set; }
        public int? PositionId { get; set; }
        public int? BusinessTypeId { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}
