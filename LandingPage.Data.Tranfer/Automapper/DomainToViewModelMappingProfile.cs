using AutoMapper;
using LandingPage.Data.Entities;
using LandingPage.Data.Tranfer.ViewModels.Campaigns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingPage.Data.Tranfer.Automapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Gift, GiftViewModel>();
        }
    }
}
