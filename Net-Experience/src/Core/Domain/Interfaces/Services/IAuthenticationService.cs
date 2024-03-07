using Net.Experience.Domain.Dtos;
using System.Threading.Tasks;

namespace Net.Experience.Domain.Interfaces.Services
{
    public interface IAuthenticationService
    {
        Task<LoginDto> AuthenticationAsync(AuthenticationDto authenticationDto);
        Task LogoutAsync();
    }
}
