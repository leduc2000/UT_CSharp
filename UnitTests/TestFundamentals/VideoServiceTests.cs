using NUnit.Framework;
using TestNinja.Mocking;

namespace UnitTests.TestFundamentals
{
    [TestFixture]
    public class VideoServiceTests
    {
        [Test]
        public void ReadVideoTitle_IsEmpty_ReturnError()
        {
            var videoService = new VideoService();

            var result = videoService.ReadVideoTitle(new FakeFileReader());

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
