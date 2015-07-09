using System;
using Xunit;

namespace CodeConnect.TestDemo.xUnit
{
    public class XUnitTestClass : IDisposable, IClassFixture<XUnitTestFixture>
    {
        public XUnitTestClass()
        {
            System.Diagnostics.Debug.WriteLine("XUnitTestClass..ctor");
        }

        [Fact()]
        public void TestMethod1()
        {
            System.Diagnostics.Debug.WriteLine("XUnitTestClass.TestMethod1");
        }

        [Fact()]
        public void TestMethod2()
        {
            System.Diagnostics.Debug.WriteLine("XUnitTestClass.TestMethod2");
        }

        [Theory]
        [InlineData("1")]
        [InlineData("2")]
        [InlineData("3")]
        public void TestMethod3(string index)
        {
            System.Diagnostics.Debug.WriteLine("XUnitTestClass.TestMethod3({0})", new string[]{ index });
        }

        public void Dispose()
        {
            System.Diagnostics.Debug.WriteLine("XUnitTestClass.Dispose");
        }
    }

    public class XUnitTestFixture : IDisposable
    {
        public XUnitTestFixture()
        {
            System.Diagnostics.Debug.WriteLine("XUnitTestFixture..ctor");
        }

        public void Dispose()
        {
            System.Diagnostics.Debug.WriteLine("XUnitTestFixture.Dispose");
        }
    }
}
