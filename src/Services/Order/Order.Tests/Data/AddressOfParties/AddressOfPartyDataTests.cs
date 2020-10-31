using CommonTests.OverallTests;
using Identity.Data.AddressOfParty;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sooduskorv_MVC.Data.CommonData;

namespace Order.Tests.Data.AddressOfParties
{
    [TestClass]
    public class AddressOfPartyDataTests : SealedClassTests<AddressOfPartyData, AddressedEntityData>
    {
        [TestMethod]
        public void PartyIdTest() =>
           isNullableProperty(() => obj.PartyId, x => obj.PartyId = x);
    }
}
