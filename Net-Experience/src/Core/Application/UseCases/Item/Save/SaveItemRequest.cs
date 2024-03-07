﻿using MediatR;
using Net.Experience.Common.Helpers;

namespace Net.Experience.Application.UseCases.Item.Save
{
    public class SaveItemRequest : IRequest<Response<SaveItemResult>>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
