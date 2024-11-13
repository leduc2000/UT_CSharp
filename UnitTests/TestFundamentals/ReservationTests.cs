using NUnit.Framework;
using TestNinja.Fundamentals;

// Nuget NUnit 3.8.1, NUnit3TestAdapter 3.8.0
namespace UnitTests.TestFundamentals
{
    // Rename by R
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UseIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Add();

            // Action
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Add { MadeBy = user };

            // Action
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingTheReservation_ReturnsFalse()
        {
            // Arrange
            var reservation = new Add { MadeBy = new User() };

            // Action
            var result = reservation.CanBeCancelledBy(new User());

            // Assert
            Assert.IsFalse(result);
        }
    }
}
