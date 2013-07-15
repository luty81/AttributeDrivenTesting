using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AttributeDrivenTesting.Extensions;


namespace AttributeDrivenTesting.Sample.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorPublicMethodsTests()
        {
            var calculator = new Calculator();

            calculator.TestAllPublicMethods();
        }
    }
}
