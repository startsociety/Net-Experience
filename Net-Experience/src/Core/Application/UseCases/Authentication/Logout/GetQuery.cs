using MediatR;
using Net.Experience.Common.Helpers;

namespace Net.Experience.Application.UseCases.Authentication.Logout
{
    public class GetQuery : IRequest<Response<bool>>
    {
    }
}
