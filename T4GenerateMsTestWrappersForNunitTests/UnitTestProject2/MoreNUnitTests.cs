using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    [TestFixture]
    public class MoreNUnitTests
    {
        [Test]
        public void PassingNUnitTestInAnotherClass()
        {
            Trace.WriteLine("NUnit Test");
            Assert.AreEqual(1, 1, "This is working nunit");
        }

    }
}
