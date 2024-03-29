﻿using Catalog.Data.CatalogedProducts;
using Catalog.Domain.Catalog;
using Sooduskorv_MVC.Aids.Methods;

namespace Catalog.Facade.Catalog
{
    public static class CatalogedProductViewFactory
    {
        public static CatalogedProductView Create(CatalogedProduct o)
        {
            var v = new CatalogedProductView();
            Copy.Members(o.Data, v);

            return v;
        }
        public static CatalogedProduct Create(CatalogedProductView v)
        {
            var d = new CatalogedProductData();
            Copy.Members(v, d);

            return new CatalogedProduct(d);
        }
    }
}
