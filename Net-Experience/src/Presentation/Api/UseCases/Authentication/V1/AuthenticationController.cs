using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Net_Experience.UseCases.Authentication.V1
{
    [ApiController]
    //[EnableCors("allowSpecificOrigins")]
    [Route("Auth")]
    public partial class AuthenticationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AuthenticationController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
