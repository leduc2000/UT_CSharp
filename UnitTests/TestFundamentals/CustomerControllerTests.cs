using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTests.TestFundamentals
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);

            // Not Found
            Assert.That(result, Is.TypeOf<NotFound>());
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnOk()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(200);

            // Not Found
            Assert.That(result, Is.TypeOf<Ok>());
            Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}
