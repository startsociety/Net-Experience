using AutoMapper;
using MediatR;
using Net.Experience.Common.Helpers;
using Net.Experience.Domain.Dtos;
using Net.Experience.Domain.Interfaces.Services;
using System.Threading;
using System.Threading.Tasks;

namespace Net.Experience.Application.UseCases.Authentication.Login
{
    public class LoginHandler : IRequestHandler<LoginRequest, Response<LoginResult>>
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IMapper _mapper;
        public LoginHandler(IAuthenticationService authenticationService, IMapper mapper) 
        {
            _authenticationService = authenticationService;
            _mapper = mapper;
        }
        public async Task<Response<LoginResult>> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var response = await _authenticationService.AuthenticationAsync(_mapper.Map<AuthenticationDto>(request));

            return new Response<LoginResult>(new LoginResult(response.Menssage, response.Token));
        }
    }
}
