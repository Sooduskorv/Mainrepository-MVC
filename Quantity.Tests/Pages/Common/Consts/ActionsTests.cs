﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quantity.Pages.Common.Consts;
using Sooduskorv_MVC.CommonTests.OverallTests;

namespace Quantity.Tests.Pages.Common.Consts
{
    [TestClass]
    public class ActionsTests : BaseTests
    {

        [TestInitialize] public virtual void TestInitialize() => type = typeof(Actions);
        [TestMethod] public void EditTest() => Assert.AreEqual("Edit", Actions.Edit);
        [TestMethod] public void DetailsTest() => Assert.AreEqual("Details", Actions.Details);
        [TestMethod] public void DeleteTest() => Assert.AreEqual("Delete", Actions.Delete);
        [TestMethod] public void IndexTest() => Assert.AreEqual("Index", Actions.Index);

    }
}
