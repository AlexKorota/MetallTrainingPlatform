using AutoMapper;
using MetallTrainingPlatform.Domain.DTO;
using MetallTrainingPlatform.Domain.Entities;

namespace MetallTrainingPlatform.Domain.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateUsersMap();
        }

        private void CreateUsersMap()
        {
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();
        }
    }
}
