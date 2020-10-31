using CommonTests.OverallTests;
using Identity.Data.AddressOfCustomer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sooduskorv_MVC.Data.CommonData;

namespace Order.Tests.Data.AddressOfCustomer
{

    [TestClass]
    public class AddressOfCustomerDataTests : SealedClassTests<AddressOfCustomerData, AddressedEntityData>
    {
        [TestMethod]
        public void CustomerIdTest() =>
           isNullableProperty(() => obj.CustomerId, x => obj.CustomerId = x);
    }
}
