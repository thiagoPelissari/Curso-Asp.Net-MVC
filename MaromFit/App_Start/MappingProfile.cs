using AutoMapper;
using MaromFit.Dtos;
using MaromFit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaromFit.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Client, ClientDto>();
            Mapper.CreateMap<ClientDto, Client>();
        }
    }
}