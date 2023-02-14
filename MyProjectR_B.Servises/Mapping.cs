using AutoMapper;
using MyProjectR_B.Recources.DTOs;
using MyProjectR_B.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectR_B.Servises
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            //CreateMap<FontSize, FontSizeDTO>().ReverseMap();
            CreateMap<Children, ChildrenDTO>().ReverseMap();

        }

    }
}
