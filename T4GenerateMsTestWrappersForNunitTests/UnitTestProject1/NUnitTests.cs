using System;
using NUnit.Framework;
using System.Diagnostics;
using System.Linq;

namespace UnitTestProject1
{
    [TestFixture]
    public class NUnitTests
    {
        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            Trace.WriteLine("NUnit Fixture Setup");
        }

        [TestFixtureTearDown]
        public void FixtureTearDown()
        {
            Trace.WriteLine("NUnit Fixture TearDown");
        }

        [SetUp]
        public void Setup()
        {
            Trace.WriteLine("NUnit Setup");
        }
        
        [TearDown]
        public void TearDown()
        {
            Trace.WriteLine("NUnit TearDown");
        }

        [Test]
        public void FailingNUnitTest()
        {
            Trace.WriteLine("NUnit Test");
            Assert.AreEqual(1, 2, "This is nunit");
        }

        [Test]
        public void PassingNUnitTest()
        {
            Trace.WriteLine("NUnit Test");
            Assert.AreEqual(1, 1, "This is working nunit");
        }




    }
}
