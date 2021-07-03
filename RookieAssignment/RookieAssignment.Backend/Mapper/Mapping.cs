using AutoMapper;
using RookieAssignment.Backend.Models;
using RookieAssignment.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieAssignment.Backend.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<MenuItem, MenuItemDTO>().ReverseMap();
            CreateMap<MenuItemComment, MenuItemCommentDTO>().ReverseMap();
        }
    }
}
