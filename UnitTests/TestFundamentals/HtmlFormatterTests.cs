using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTests.TestFundamentals
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEnCloseTheStringWithStrongElement()
        {
            // Arrange
            // Action
            var format = new HtmlFormatter();

            var result = format.FormatAsBold("good content");

            // Assert
            Assert.That(result, Is.EqualTo("<strong>good content</strong>").IgnoreCase);

            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("good content"));
        }
    }
}
