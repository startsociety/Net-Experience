﻿using System;

namespace Net.Experience.Application.UseCases.Item.GetById
{
    public class GetItemResult 
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public GetItemResult(Domain.Entities.Item itemDto)
        {
            Id = itemDto.Id;
            Title = itemDto.Title;
            Description = itemDto.Description;
        }
    }
}
