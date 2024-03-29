﻿using Catalog.Data.Product;
using Sooduskorv_MVC.Facade;
using System.Collections.Generic;
using System.ComponentModel;

namespace Catalog.Facade.Product
{
    public sealed class ProductTypeView : DescribedEntityView
    {
        public ProductKind ProductKind { get; set; } = ProductKind.Product;
        public double Amount { get; set; } = 2.45;
        [DisplayName("Unit")] public string UnitId { get; set; } = "asd";
        [DisplayName("Brand")]
        public string BrandId { get; set; } = "asd";
        [DisplayName("Country of origin")]
        public string CountryOfOriginId { get; set; } = "asd";
        public string BarCode { get; set; } = "asd";
        public string Image { get; set; } = "asd";
        public List<PartyInstanceView> parties { get; set; } = new List<PartyInstanceView> { new PartyInstanceView() };

        public int ProductsInUserBasket
        {
            get;// TODO -1
            set;// TODO -1
        } = 0;


    }
}
