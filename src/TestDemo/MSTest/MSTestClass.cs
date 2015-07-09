using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeConnect.TestDemo.MSTest
{
    [TestClass]
    public class MSTestClass : IDisposable
    {
        public MSTestClass()
        {
            System.Diagnostics.Debug.WriteLine("MSTestClass..ctor");
        }

        [ClassInitialize]
        static public void ClassInitialize(TestContext context)
        {
            System.Diagnostics.Debug.WriteLine("MSTestClass.ClassInitialize");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            System.Diagnostics.Debug.WriteLine("MSTestClass.TestInitialize");
        }

        [TestMethod]
        public void TestMethod1()
        {
            System.Diagnostics.Debug.WriteLine("MSTestClass.TestMethod1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            System.Diagnostics.Debug.WriteLine("MSTestClass.TestMethod2");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            System.Diagnostics.Debug.WriteLine("MSTestClass.TestCleanup");
        }

        [ClassCleanup]
        static public void ClassCleanup()
        {
            System.Diagnostics.Debug.WriteLine("MSTestClass.ClassCleanup");
        }

        public void Dispose()
        {
            System.Diagnostics.Debug.WriteLine("MSTestClass.Dispose");
        }
    }
}
