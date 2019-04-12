using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Shouldly;

namespace UnitTest
{
    public class ShouldlyFirstSteps
    {
        public int calculate(int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }

        [Fact]
        public void testOne()
        {
            int result = 5;
            result.ShouldBe(calculate(2, 3));
        }

        [Fact]
        public void testTwo()
        {
            int result = 6;
            result.ShouldNotBe(calculate(2, 3));
        }

        [Fact]
        public void testThree()
        {
            int result = 6;
            result.ShouldNotBeSameAs(5);
        }


        [Fact]
        public void testFour()
        {
            int result = 5;
            result.ShouldNotBeSameAs(5);
        }

    }
}
