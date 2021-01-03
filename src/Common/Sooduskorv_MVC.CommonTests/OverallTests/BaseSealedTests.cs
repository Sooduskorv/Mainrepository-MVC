﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sooduskorv_MVC.CommonTests.OverallTests
{

    public abstract class BaseSealedTests<TClass, TBaseClass> : BaseClassTests<TClass, TBaseClass> {


        [TestMethod] public void IsSealed() {
            Assert.IsTrue(type.IsSealed);
        }


    }

}
