using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Connect.Models;
using Connect.Controllers.Resources;

namespace Connect.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryResource>();
            CreateMap<Vocation, VocationResource>()
                .ForMember(v => v.Category, opt => opt.MapFrom(x => x.Category.Name));
        }
    }
}