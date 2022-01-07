using AutoMapper;
using LandingPage.Data.Entities;
using LandingPage.Data.Tranfer.ViewModels;
using LandingPage.Data.Tranfer.ViewModels.Campaigns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingPage.Data.Tranfer.Automapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CampaignViewModel, Campaign>().ConstructUsing(c=> new Campaign(c.Name,c.RuleId,c.Description,c.DateStart,c.DateEnd,c.Status)).MaxDepth(2);
            CreateMap<CampaignDetailViewModel, CampaignDetail>().ConstructUsing(c=> new CampaignDetail(c.CampaignId,c.WinnerId,c.AwareDate,c.PhoneNumber,c.GiftId)).MaxDepth(2);
            CreateMap<UserViewModel, User>().ConstructUsing(c=> new User(c.FullName,c.PhoneNumber,c.BirthDay,c.PositionId,c.BusinessTypeId,c.Password,c.UserName));
        }
    }
}
