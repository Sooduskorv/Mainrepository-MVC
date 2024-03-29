﻿
using Catalog.Data.Price;
using Catalog.Domain.Prices;
using Catalog.Infra.Common;

namespace Catalog.Infra.Prices
{
    public sealed class PricesRepository :
       UniqueEntityRepository<Price, PriceData>, IPricesRepository
    {
        public PricesRepository(CatalogDbContext c) : base(c, c.Prices) { }
        protected internal override Price toDomainObject(PriceData d)
            => new Price(d);
    }
}

