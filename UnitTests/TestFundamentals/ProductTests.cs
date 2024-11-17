using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace UnitTests.TestFundamentals
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount()
        {
            var customer = new Mock<ICustomer>();
            customer.Setup(c => c.IsGold).Returns(true);

            var product = new Product { ListPrice = 100  };

            var result = product.GetPrice(customer.Object);
        }
    }
}
