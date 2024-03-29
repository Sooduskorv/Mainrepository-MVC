﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Bff.HttpAggregator.Domain.CatalogService.QueryRequest;
using WebMVC.Bff.HttpAggregator.Domain.DTO;

namespace WebMVC.HttpAggregator.Domain.Catalog.QueriesHandlers
{
    public class GetAllProductsQueryHandler<T> : IRequestHandler<T, ActionResult<IEnumerable<ProductDto>>> where T : GetAllProductsQuery, IRequest<ActionResult<IEnumerable<ProductDto>>>
    {
        /*private readonly IQueryHandler<PictureQuery, Resource> _resourceQueryHandler;*/

        // TODO kas sobiks ka ActionResult??
        /*public GetAllProductsQueryHandler(/*IQueryHandler<PictureQuery, Resource> resourceQueryHandler#1#)
        {
            /*_resourceQueryHandler = resourceQueryHandler;#1#
        }*/


        public Task<ActionResult<IEnumerable<ProductDto>>> Handle(T request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}