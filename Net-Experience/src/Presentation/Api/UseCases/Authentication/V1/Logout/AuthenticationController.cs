using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net.Experience.Application.UseCases.Authentication.Logout;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.Authentication.V1
{
    public partial class AuthenticationController
    {
        [Authorize]
        [HttpGet]
        [Route("Logout")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> LogoutAsync()
        {

            await _mediator.Send(new GetQuery());

            return Ok();
        }
    }
}
