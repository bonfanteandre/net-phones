using AutoMapper;
using NetPhones.App.ViewModels;
using NetPhones.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetPhones.App.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Contact, ContactViewModel>().ReverseMap();
        }
    }
}
