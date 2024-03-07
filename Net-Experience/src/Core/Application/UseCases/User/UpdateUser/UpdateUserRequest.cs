﻿using MediatR;
using Net.Experience.Common.Helpers;
using System;

namespace Net.Experience.Application.UseCases.User.UpdateUser
{
    public class UpdateUserRequest : IRequest<Response<UpdateUserResult>>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
