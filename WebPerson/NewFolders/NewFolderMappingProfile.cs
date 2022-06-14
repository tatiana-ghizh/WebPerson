using AutoMapper;
using WebPerson.Entities;

namespace WebPerson.NewFolders
{
    public class NewFolderMappingProfile : Profile
    {
        public NewFolderMappingProfile()
        {
            CreateMap<Person, PersonDto>();
            CreateMap<PersonDto, Person>();
        }
    }
}
