using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alpha.API.Data.Entities;
using Alpha.API.Models;
using AutoMapper;
namespace Alpha.API.Data
{
    public class AlphaProfile : Profile
    {
        public AlphaProfile()
        {
            this.CreateMap<User, UserModel>()
                .ForMember(u => u.Address1, o => o.MapFrom(m => m.Address.Address1))
                .ForMember(u => u.Address2, o => o.MapFrom(m => m.Address.Address2))
                .ForMember(u => u.Address3, o => o.MapFrom(m => m.Address.Address3))
                .ForMember(u => u.CityTown, o => o.MapFrom(m => m.Address.CityTown))
                .ForMember(u => u.StateProvince, o => o.MapFrom(m => m.Address.StateProvince))
                .ForMember(u => u.PostalCode, o => o.MapFrom(m => m.Address.PostalCode))
                .ForMember(u => u.Country, o => o.MapFrom(m => m.Address.Country));
        }
    }
}

