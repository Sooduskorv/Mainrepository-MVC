﻿using CommonTests.OverallTests;
using Identity.Data.Addresses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sooduskorv_MVC.Data.CommonData;

namespace Order.Tests.Data.Addresses
{

    [TestClass]
    public class AddressDataTests : SealedClassTests<AddressData, PeriodData>
    {
        [TestMethod]
        public void AddressTest() =>
            isProperty(() => obj.Address, x => obj.Address = x);
        [TestMethod]
        public void EmailAddressTest() =>
            isProperty(() => obj.EmailAddress, x => obj.EmailAddress = x);


        [TestMethod] public void PostalCodeTest() => isNullableProperty(() => obj.PostalCode, x => obj.PostalCode = x);

        [TestMethod]
        public void PhoneTest() =>
            isProperty(() => obj.Phone, x => obj.Phone = x)
            ;
        [TestMethod]
        public void AreaTest() =>
            isNullableProperty(() => obj.Area, x => obj.Area = x);
    }
}
