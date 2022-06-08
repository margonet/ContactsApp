using ContactsApp;
using NUnit.Framework;
using System;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class PhoneNumberTests
    {
        [Test]
        public void Equals_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var phoneNumber = new PhoneNumber();
            PhoneNumber other = null;

            // Act
            var result = phoneNumber.Equals(
                other);

            // Assert
            Assert.Fail();
        }

        [Test]
        public void Equals_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var phoneNumber = new PhoneNumber();
            object obj = null;

            // Act
            var result = phoneNumber.Equals(
                obj);

            // Assert
            Assert.Fail();
        }

        [Test]
        public void GetHashCode_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var phoneNumber = new PhoneNumber();

            // Act
            var result = phoneNumber.GetHashCode();

            // Assert
            Assert.Fail();
        }
    }
}
