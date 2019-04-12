using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Xunit;
using Shouldly;

namespace UnitTest
{
    public interface iFoo2
    {
        bool valueIsCorrect(int valueParam);
    }

    public class Moq4FirstSteps
    {
        [Fact]
        public void testOne() {
            Mock<iFoo2> mockObject = new Mock<iFoo2>();
            mockObject.Setup(s => s.valueIsCorrect(3)).Returns(true);
            mockObject.Object.valueIsCorrect(3).ShouldBe(true);
            mockObject.VerifyAll();
        }

        [Fact]
        public void testTwo()
        {
            Mock<iFoo2> mockObject = new Mock<iFoo2>();
            mockObject.Object.valueIsCorrect(4).ShouldBe(false);
            mockObject.VerifyAll();
            mockObject.Reset();
        }

    }
}
