﻿
using Catalog.Data.CatalogEntries;
using Catalog.Domain.Catalog;
using Catalog.Infra.Common;

namespace Catalog.Infra.Catalog
{
    public sealed class CatalogEntriesRepository : UniqueEntityRepository<CatalogEntry, CatalogEntryData>,
        ICatalogEntriesRepository
    {

        public CatalogEntriesRepository(CatalogDbContext c = null) : base(c, c?.CatalogEntries) { }

        protected internal override CatalogEntry toDomainObject(CatalogEntryData d) => new CatalogEntry(d);

    }
}

