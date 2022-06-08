using ContactsApp;
using NUnit.Framework;
using System;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ProjectTests
    {
        [Test]
        public void SearchContactByString_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var project = new Project();
            string searchString = null;

            // Act
            var result = project.SearchContactByString(
                searchString);

            // Assert
            Assert.Fail();
        }

        //[Test]
        //public void SearchSurnamesByBirthday_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var project = new Project();
        //    List Contacts = null;

        //    // Act
        //    var result = project.SearchSurnamesByBirthday(Contacts);

        //    // Assert
        //    Assert.Fail();
        //}

        [Test]
        public void Equals_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var project = new Project();
            Project other = null;

            // Act
            var result = project.Equals(
                other);

            // Assert
            Assert.Fail();
        }

        [Test]
        public void Equals_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var project = new Project();
            object obj = null;

            // Act
            var result = project.Equals(
                obj);

            // Assert
            Assert.Fail();
        }

        [Test]
        public void GetHashCode_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var project = new Project();

            // Act
            var result = project.GetHashCode();

            // Assert
            Assert.Fail();
        }
    }
}
