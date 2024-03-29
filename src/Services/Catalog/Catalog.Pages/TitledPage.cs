﻿using Catalog.Domain;
using Catalog.Domain.Common;
using Catalog.Domain.Prices;
using Catalog.Domain.Product;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sooduskorv_MVC.Aids.Constants;
using Sooduskorv_MVC.Data.CommonData;
using Sooduskorv_MVC.Facade;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.Pages
{
    public abstract class TitledPage<TRepository, TDomain, TView, TData> :
       PagedPage<TRepository, TDomain, TView, TData>
       where TRepository : class, ICrudMethods<TDomain>, ISorting, IFiltering, IPaging
       where TView : UniqueEntityView
    {

        protected internal TitledPage(TRepository r, string title) : base(r) => PageTitle = title;

        public string PageTitle { get; }

        public string PageSubTitle => FixedValue is null
        ? string.Empty
        : $"{pageSubtitle()}";

        protected virtual string pageSubtitle() => string.Empty;

        public Uri PageUrl => pageUrl();
        public Uri CreateUrl => createUrl();

        protected internal Uri createUrl()
            => new Uri($"{PageUrl}/Create" +
                       "?handler=Create" +
                       $"&pageIndex={PageIndex}" +
                       $"&sortOrder={SortOrder}" +
                       $"&searchString={SearchString}" +
                       $"&fixedFilter={FixedFilter}" +
                       $"&fixedValue={FixedValue}", UriKind.Relative);

        protected abstract Uri pageUrl();

        public Uri IndexUrl => indexUrl();

        protected internal Uri indexUrl() =>
            new Uri($"{PageUrl}/Index?handler=Index&fixedFilter={FixedFilter}&fixedValue={FixedValue}", UriKind.Relative);
        //TODO kole asi välja vahetada
        protected internal static IEnumerable<SelectListItem> newItemsList<TTDomain, TTData>(IRepository<TTDomain> r,
            Func<TTDomain, bool> condition = null)
            where TTDomain : IEntity<TTData>
            where TTData : NameEntityData, new()
        {
            var items = r?.Get().GetAwaiter().GetResult();
            var l = items is null
                ? new List<SelectListItem>()
                : condition is null ?
                    items
                    .Select(m => new SelectListItem(m.Data.Name, m.Data.Id))
                    .ToList() :
                    items
                    .Where(condition)
                    .Select(m => new SelectListItem(m.Data.Name, m.Data.Id))
                    .ToList();
            l.Insert(0, new SelectListItem(Word.Unspecified, null));
            return l;
        }
        protected internal static IEnumerable<SelectListItem> newPricesList<Price, PriceData>(IPricesRepository r,
            Func<Price, bool> condition = null)
            where Price : IEntity<PriceData>
            where PriceData : NameEntityData, new()
        {
            var items = r?.Get().GetAwaiter().GetResult();
            var l = items is null
                ? new List<SelectListItem>()
                : condition is null ?
                    items
                    .Select(m => new SelectListItem(m.Data.Amount.ToString(), m.Data.ProductInstanceId))
                    .ToList() :
                     new List<SelectListItem>();
            l.Insert(0, new SelectListItem(Word.Unspecified, null));
            return l;
        }
        protected internal static IEnumerable<SelectListItem> newSubCategoriesList<ProductCategory, ProductCategoryData>(IProductCategoriesRepository r,
            Func<ProductCategory, bool> condition = null)
            where ProductCategory : IEntity<ProductCategoryData>
            where ProductCategoryData : NameEntityData, new()
        {
            var items = r?.Get().GetAwaiter().GetResult();
            var l = items is null
                ? new List<SelectListItem>()
                : condition is null ?
                    items
                    .Select(m => new SelectListItem(m.Data.BaseCategoryId, m.Data.Id))
                    .ToList() :
                     new List<SelectListItem>();
            l.Insert(0, new SelectListItem(Word.Unspecified, null));
            return l;
        }
        protected internal static IEnumerable<SelectListItem> newPartiesList<ProductInstance, ProductInstanceData>(IProductInstancesRepository r,
            Func<ProductInstance, bool> condition = null)
            where ProductInstance : IEntity<ProductInstanceData>
            where ProductInstanceData : NameEntityData, new()
        {
            var items = r?.Get().GetAwaiter().GetResult();
            var l = items is null
                ? new List<SelectListItem>()
                : condition is null ?
                    items
                    .Select(m => new SelectListItem(m.Data.Id, m.Data.PartyId))
                    .ToList() :
                     new List<SelectListItem>();
            l.Insert(0, new SelectListItem(Word.Unspecified, null));
            return l;
        }
        protected internal static IEnumerable<SelectListItem> newInstancesList<ProductInstance, ProductInstanceData>(IProductInstancesRepository r,
           Func<ProductInstance, bool> condition = null)
           where ProductInstance : IEntity<ProductInstanceData>
           where ProductInstanceData : NameEntityData, new()
        {
            var items = r?.Get().GetAwaiter().GetResult();
            var l = items is null
                ? new List<SelectListItem>()
                : condition is null ?
                    items
                    .Select(m => new SelectListItem(m.Data.Id, m.Data.ProductTypeId))
                    .ToList() :
                     new List<SelectListItem>();
            l.Insert(0, new SelectListItem(Word.Unspecified, null));
            return l;
        }



        protected internal static string itemName(IEnumerable<SelectListItem> list, string id)
        {
            if (list is null) return Word.Unspecified;

            foreach (var m in list)
                if (m.Value == id)
                    return m.Text;

            return Word.Unspecified;
        }


        public virtual bool IsMasterDetail() => PageSubTitle != string.Empty;

    }
}
