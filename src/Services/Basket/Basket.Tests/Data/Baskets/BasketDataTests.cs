﻿using Basket.Data.Baskets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sooduskorv_MVC.CommonTests.OverallTests;
using Sooduskorv_MVC.Data.CommonData;

namespace Basket.Tests.Data.Baskets
{
    [TestClass]
    public class BasketDataTests : SealedClassTests<BasketData, NameEntityData>
    {
        [TestMethod]
        public void CustomerIdTest() =>
           isNullableProperty(() => obj.BuyerId, x => obj.BuyerId = x);
    }
}
