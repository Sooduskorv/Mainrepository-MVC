﻿/*
using System.Threading.Tasks;

namespace Sooduskorv_MVC.Infra
{
    public abstract class UniqueEntityRepository<TDomain, TData> : PaginatedRepository<TDomain, TData>
        where TDomain : IEntity<TData>
        where TData : UniqueEntityData, new()
    {

        protected UniqueEntityRepository(DbContext c, DbSet<TData> s) : base(c, s) { }

        protected override async Task<TData> getData(string id)
            => await dbSet.FirstOrDefaultAsync(m => m.Id == id);

        protected override TData getDataById(TData d) => dbSet.Find(d.Id);

    }
}
*/
