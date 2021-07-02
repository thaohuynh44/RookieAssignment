using AutoMapper;
using RookieAssignment.Backend.Models;
using RookieAssignment.Backend.Models.DTOs;
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
        }
    }
}
