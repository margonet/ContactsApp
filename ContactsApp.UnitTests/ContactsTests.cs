using ContactsApp;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ContactTests
    {
        [Test]
        public void Clone_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var contact = new Contact();

            // Act
            var result = contact.Clone();

            // Assert
            Assert.Fail();
        }
    }
}