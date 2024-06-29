using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using UnitTesting1;

namespace UnitTesting1.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AddTest_GivenTwoInts_ReturnInt()
        {
            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Assert.Equal(3, result);
        }
        [Fact]
        public void AddDoubleTest_GivenTwoDouble_ReturnsDouble()
        {
            var calculator = new Calculator();
            var result = calculator.AddDouble(1.3, 3.2);
            Assert.Equal(4.5, result);
        }

    }
}
