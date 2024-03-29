﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sooduskorv_MVC.CommonTests.OverallTests;
using Sooduskorv_MVC.Data.CommonData;

namespace CommonTests.DataTests.CommonDataTests
{
    [TestClass]
    public class PricedEntityDataTests : AbstractClassTests<PricedEntityData, PeriodData>
    {
        private class testClass : PricedEntityData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }
        [TestMethod]
        public void PriceTest()
            => isProperty(() => obj.Price, x => obj.Price = x);
    }
}