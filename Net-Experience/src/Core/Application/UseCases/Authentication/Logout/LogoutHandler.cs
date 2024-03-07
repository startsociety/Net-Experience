using MediatR;
using Net.Experience.Common.Helpers;
using Net.Experience.Domain.Interfaces.Services;
using System.Threading;
using System.Threading.Tasks;

namespace Net.Experience.Application.UseCases.Authentication.Logout
{
    public class LogoutHandler : IRequestHandler<GetQuery, Response<bool>>
    {
        private readonly IAuthenticationService _authenticationService;
        public LogoutHandler(IAuthenticationService authenticationService) 
        {
            _authenticationService = authenticationService;
        }
        public async Task<Response<bool>> Handle(GetQuery request, CancellationToken cancellationToken)
        {
            await _authenticationService.LogoutAsync();

            return new Response<bool>(true);
        }
    }
}
