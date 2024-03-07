using AutoMapper;
using Net.Experience.Application.UseCases.Authentication.Login;
using Net.Experience.Domain.Dtos;

namespace Net.Experience.Application.AutoMapper
{
    public class AutoMappingAuthentication : Profile
    {
        public AutoMappingAuthentication()
        {
            CreateMap<LoginRequest, AuthenticationDto>();
        }
    }
}
