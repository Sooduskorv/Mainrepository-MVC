﻿using System.Threading.Tasks;
using WebMVC.Bff.HttpAggregator.Domain.BasketService;

namespace WebMVC.Bff.HttpAggregator.Infra.Repositories
{
    public class BasketServiceRepository<T> : IBasketService<T> where T : class
    {
        public Task<T> Get(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}