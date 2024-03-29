﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order.Data.ShipMethodOfParty;
using Sooduskorv_MVC.CommonTests.OverallTests;
using Sooduskorv_MVC.Data.CommonData;

namespace Order.Tests.Data.ShipMethodsOfParties
{

    [TestClass]
    public class ShipMethodsOfPartyDataTests : SealedClassTests<ShipMethodsOfPartyData, PricedEntityData>
    {

        [TestMethod]
        public void PartyIdTest() =>
            isNullableProperty(() => obj.PartyId, x => obj.PartyId = x);


        [TestMethod]
        public void ShipMethodIdTest() =>
            isNullableProperty(() => obj.ShipMethodId, x => obj.ShipMethodId = x);

        [TestMethod]
        public void PriceTest() =>
           isProperty(() => obj.Price, x => obj.Price = x);

        [TestMethod]
        public void MinimalOrderPriceTest() =>
           isProperty(() => obj.MinimalOrderPrice, x => obj.MinimalOrderPrice = x);

    }
}
