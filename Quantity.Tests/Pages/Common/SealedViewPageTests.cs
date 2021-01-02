﻿using Quantity.Domain.Common;
using Quantity.Facade.Common;
using Quantity.Pages.Common;

namespace Quantity.Tests.Pages.Common {

    public abstract class SealedViewPageTests<TClass, TRepository, TObj, TView, TData>
        : SealedPageTests<TClass, ViewPage<TRepository, TObj, TView, TData>, TRepository, TObj, TView, TData>
        where TClass : ViewPage<TRepository, TObj, TView, TData>
        where TRepository : class, ICrudMethods<TObj>, ISorting, IFiltering, IPaging
        where TObj : IEntity<TData>
        where TData : PeriodData, new()
        where TView : PeriodView {
    }

}
