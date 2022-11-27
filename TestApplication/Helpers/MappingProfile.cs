using AutoMapper;
using TestApplication.Dtos;
using TestApplication.Models;

namespace TestApplication.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<QueueDto, QueueEntity>()
                .ForMember(x => x.Status, n => n.MapFrom(c => c.Status));
        }
    }
}
