using Net.Experience.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;

namespace Net.Experience.Domain.Interfaces.Services
{
    public interface ITokenService
    {
        JwtSecurityToken GetToken(User user);
    }
}
