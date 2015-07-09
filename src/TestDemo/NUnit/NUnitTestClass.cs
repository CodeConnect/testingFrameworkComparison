using System;
using NUnit.Framework;

namespace CodeConnect.TestDemo.NUnit
{
    [TestFixture]
    public class NUnitTestClass : IDisposable
    {
        public NUnitTestClass()
        {
            System.Diagnostics.Debug.WriteLine("NUnitTestClass..ctor");
        }

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            System.Diagnostics.Debug.WriteLine("NUnitTestClass.TestFixtureSetUp");
        }

        [SetUp]
        public void SetUp()
        {
            System.Diagnostics.Debug.WriteLine("NUnitTestClass.SetUp");
        }

        [Test]
        public void TestMethod1()
        {
            System.Diagnostics.Debug.WriteLine("NUnitTestClass.TestMethod1");
        }

        [Test]
        public void TestMethod2()
        {
            System.Diagnostics.Debug.WriteLine("NUnitTestClass.TestMethod2");
        }

        [TearDown]
        public void TearDown()
        {
            System.Diagnostics.Debug.WriteLine("NUnitTestClass.TearDown");
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            System.Diagnostics.Debug.WriteLine("NUnitTestClass.TestFixtureTearDown");
        }

        public void Dispose()
        {
            System.Diagnostics.Debug.WriteLine("NUnitTestClass.Dispose");
        }
    }
}
