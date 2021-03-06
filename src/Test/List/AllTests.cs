﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.List
{
    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AllTests
    {
        [TestMethod]
        public void WhenAll()
        {
            IList<int> list = new[] { 1, 2, 3 };
            Assert.IsTrue(list.All(i => i > 0));
        }

        [TestMethod]
        public void WhenOneNot()
        {
            IList<int> list = new[] { 1, 2, 3 };
            Assert.IsFalse(
                list.All(i => i < 3));
        }

        [TestMethod]
        public void WhenNone()
        {
            IList<int> list = new[] { 1, 2, 3 };
            Assert.IsFalse(list.All(i => i < 0));
        }

        [TestMethod]
        public void NullInput()
        {
            IList<int> list = null;
            new Action(
                    () => list.All(i => true))
                .Should()
                .Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void NullPredicate()
        {
            IList<int> list = new[] { 1, 2, 3 };
            new Action(
                    () => list.All(null))
                .Should()
                .Throw<ArgumentNullException>();
        }
    }
}
