﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quantity.Pages.Common.Aids;
using Sooduskorv_MVC.Aids.Random;
using Sooduskorv_MVC.CommonTests.OverallTests;
using System;

namespace Quantity.Tests.Pages.Common.Aids
{

    [TestClass] public class LinkTests : BaseTests {


        [TestInitialize] public virtual void TestInitialize() => type = typeof(Link);

        [TestMethod] public void DisplayNameTest() {
            var n = GetRandom.String();
            var o = new Link(n, (Uri)null);
            Assert.AreEqual(n, o.DisplayName);
            Assert.IsNull(o.Url);
            Assert.AreEqual(n, o.PropertyName);
        }

        [TestMethod] public void UrlTest() {
            var n = GetRandom.String();
            var o = new Link(null, new Uri(n, UriKind.Relative));
            Assert.AreEqual(n, o.Url.ToString());
            Assert.IsNull(o.DisplayName);
            Assert.IsNull(o.PropertyName);
        }

        [TestMethod] public void PropertyNameTest() {
            var n = GetRandom.String();
            var o = new Link(null, null, n);
            Assert.AreEqual(n, o.PropertyName);
            Assert.IsNull(o.Url);
            Assert.IsNull(o.DisplayName);
        }

    }

}