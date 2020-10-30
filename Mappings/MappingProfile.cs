using AutoMapper;
using HealthEquityMembers.Controllers;
using HealthEquityMembers.Models;

namespace HealthEquityMembers.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MemberPatch, Member>();
        }
    }
}