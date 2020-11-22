﻿using MediatR;
using WebMVC.Bff.HttpAggregator.Domain.DTO;

namespace WebMVC.Bff.HttpAggregator.Domain.CatalogService.CommandRequest
{
    public sealed class AddToBasketCommand : IRequest<object>, IRequest<BasketDto>
    {
    }
}