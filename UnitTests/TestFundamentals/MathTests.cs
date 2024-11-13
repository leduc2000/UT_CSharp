using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTests.TestFundamentals
{
    // Black-box, TearDown
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        // SetUp
        // TearDown
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        [Ignore("Nothing Just I Want It")]
        public void Add_WhenCalled_ReturnsTheSum()
        {
            // Arrange
            // Action
            var result = _math.Add(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(3, 2, 3)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectResult)
        {
            // Arrange
            // Action
            var result = _math.Max(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectResult));
        }

        //[Test]
        //public void Max_FirstArgumentIsGreater_ReturnsFirst()
        //{
        //    // Arrange
        //    // Action
        //    var result = _math.Max(3, 2);

        //    // Assert
        //    Assert.That(result, Is.EqualTo(3));
        //}

        //[Test]
        //public void Max_SecondArgumentIsGreater_ReturnsSecond()
        //{
        //    // Arrange
        //    // Action
        //    var result = _math.Max(1, 2);

        //    // Assert
        //    Assert.That(result, Is.EqualTo(2));
        //}

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZezo_ReturnUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
        }
    }
}
