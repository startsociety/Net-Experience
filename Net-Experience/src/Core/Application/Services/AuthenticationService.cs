using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Net.Experience.Common.Helpers;
using Net.Experience.Domain.Dtos;
using Net.Experience.Domain.Entities;
using Net.Experience.Domain.Interfaces.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;

namespace Net.Experience.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<AuthenticationService> _logger;
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;

        public AuthenticationService(SignInManager<User> signInManager, ILogger<AuthenticationService> logger, UserManager<User> userManager,
                                     ITokenService tokenService) 
        {
            _signInManager = signInManager;
            _logger = logger;
            _userManager = userManager;
            _tokenService = tokenService;
        }
        public async Task<LoginDto> AuthenticationAsync(AuthenticationDto authenticationDto)
        {
            string message;
            LoginDto loginResponse;

            var user = await _userManager.FindByEmailAsync(authenticationDto.Email);

            var result = await _signInManager.PasswordSignInAsync(user, authenticationDto.Password, authenticationDto.RememberMe, false);

            message = ValidateLogin(result);
           
            loginResponse = new LoginDto(message);

            if(message == MessageGeneral.UserLoginSucess) 
            {

                loginResponse.Token = new JwtSecurityTokenHandler().WriteToken(_tokenService.GetToken(user));
            }

            return loginResponse;
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        private string ValidateLogin(SignInResult result)
        {
            string message;
            
            if (result.Succeeded)
            {
                _logger.LogInformation(MessageGeneral.UserLoginSucess);
                message = MessageGeneral.UserLoginSucess;
            }
            else
            {
                _logger.LogInformation(MessageGeneral.InvalidFormat);
                message = MessageGeneral.InvalidLogin;

            }

            return message;
        }
    }
}
