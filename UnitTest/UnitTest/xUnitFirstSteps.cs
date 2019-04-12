using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest
{
    public class Foo
    {
        public int first;
        public int second;
        public int result(int firstValue, int secondValue)
        {
            first = firstValue;
            second = secondValue;
            return firstValue + secondValue;
        }
    }

    public class xUnitFirstSteps
    {
        [Fact]
        public void testOne()
        {
            Foo f = new Foo();
            Assert.Equal(5, f.result(2, 3));
            Assert.Equal(2, f.first);
            Assert.Equal(3, f.second);
        }

        [Theory]
        [InlineData (2,3)]
        [InlineData (3,2)]
        public void testTwo(int firstValue,int secondValue)
        {
            Foo f = new Foo();
            Assert.Equal(5, f.result(firstValue, secondValue));
            Assert.Equal(firstValue, f.first);
            Assert.Equal(secondValue, f.second);
        }

        public static IEnumerable<Object[]> staticInfo(int firstValue,int secondValue)
        {
            var allData = new List<object[]>
        {
            new object[] { firstValue, secondValue}
        };

            return allData;
        }

        [Theory]
        [MemberData(nameof(staticInfo), 3,4)]
        [MemberData(nameof(staticInfo), 4,3)]
        public void testThree(int firstValue, int secondValue)
        {
            Foo f = new Foo();
            Assert.Equal(7, f.result(firstValue, secondValue));
            Assert.Equal(firstValue, f.first);
            Assert.Equal(secondValue, f.second);
        }
    }
}
