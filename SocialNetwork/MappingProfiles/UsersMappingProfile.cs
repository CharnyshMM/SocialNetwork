using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace SocialNetwork.MappingProfiles
{
    public class UsersMappingProfile : Profile
    {
        public UsersMappingProfile()
        {
            CreateMap<Database.Models.UserModel, SocialNetwork.ViewModels.ProfileViewModel>();
            CreateMap<SocialNetwork.ViewModels.ProfileViewModel, Database.Models.UserModel>();
        }
    }
}
