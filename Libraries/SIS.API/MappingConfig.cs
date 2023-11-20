using AutoMapper;
using SIS.API.DTO;
using SIS.Domain;
using SIS.Infrastructure.EFRepository.Models;

namespace SIS.API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Domain.Teacher, TeacherDTO>().ReverseMap();
            CreateMap<Concept, ConceptDTO>().ReverseMap();
            CreateMap<InfoType, InfoTypeDTO>().ReverseMap();
            CreateMap<Info, InfoDTO>().ReverseMap();

        }
    }
}