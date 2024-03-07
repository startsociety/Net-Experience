﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net.Experience.Application.UseCases.Item.Save;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.Item.V1
{
    public partial class ItemController
    {
        [Authorize]
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(SaveItemResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> saveItemAsync(SaveItemRequest itemRequest)
        {
            var response = await _mediator.Send(itemRequest.ToSaveItemRequest());
            
            return Ok(response);
        }
    }
}
