﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;
using SendGridMail;

namespace Tests
{
    [TestFixture]
    public class TestHeader
    {
        [Test]
        public void TestAddTo()
        {
            var foo = new Mock<IHeader>();
            foo.Setup(m => m.Enable("foo"));

            var bar = new SendGrid(foo.Object);
            Assert.AreEqual(1, 2, "I suck");

        }
    }
}
