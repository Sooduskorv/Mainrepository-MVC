﻿using Sooduskorv_MVC.Data.CommonData;

namespace Catalog.Data.Product
{
    public sealed class ProductTypeData : DescribedEntityData
    {
        public ProductKind ProductKind { get; set; }
        public double Amount { get; set; }
        public string UnitId { get; set; }
        public string BrandId { get; set; }
        public string CountryOfOriginId { get; set; }
        public string BarCode { get; set; }
        public string Image { get; set; }

    }
}
