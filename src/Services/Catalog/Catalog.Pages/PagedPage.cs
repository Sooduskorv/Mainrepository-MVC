﻿using Catalog.Domain;
using Sooduskorv_MVC.Facade;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Pages
{
    public abstract class PagedPage<TRepository, TDomain, TView, TData> :
       CrudPage<TRepository, TDomain, TView, TData>
       where TRepository : class, ICrudMethods<TDomain>, ISorting, IFiltering, IPaging
       where TView : UniqueEntityView
    {

        protected PagedPage(TRepository r) : base(r) { }

        public IList<TView> Items { get; private set; }

        public string SelectedId
        {
            get;
            set;
        }
        public int PageIndex
        {
            get => db.PageIndex;
            set => db.PageIndex = value;
        }
        public bool HasPreviousPage => db.HasPreviousPage;
        public bool HasNextPage => db.HasNextPage;

        public int TotalPages => db.TotalPages;

        protected internal override void setPageValues(string sortOrder, string searchString, in int? pageIndex)
        {
            SortOrder = sortOrder;
            SearchString = searchString;
            PageIndex = pageIndex ?? 0;
        }

        protected internal async Task getList(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {

            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            SortOrder = sortOrder;
            SearchString = searchString;
            CurrentFilter = getCurrentFilter(currentFilter, searchString, ref pageIndex);
            PageIndex = pageIndex ?? 1;
            Items = await getList().ConfigureAwait(true);
        }

        internal async Task<List<TView>> getList()
        {
            var l = await db.Get().ConfigureAwait(true);

            return l.Select(toView).ToList();
        }

    }
}
