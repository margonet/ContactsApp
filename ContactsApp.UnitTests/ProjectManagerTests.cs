using ContactsApp;
using NUnit.Framework;
using System;
using System.IO;
using System.Reflection;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    class ProjectManagerTest
    {
        /// <summary>
        /// путь к фалу из которого загружается сборка 
        /// </summary>
        private static readonly string LocalPath =
            Assembly.GetExecutingAssembly().Location;

        /// <summary>
        /// путь  к файлу, в котором хранится сборка 
        /// </summary>
        private static readonly string PathDirectoryName =
            Path.GetDirectoryName(LocalPath);

        /// <summary>
        /// путь к правильному файлу 
        /// </summary>
        private readonly string _projectFileName =
            PathDirectoryName + @"\TestContactsData";

        /// <summary>
        /// создает экземпляр класса project с двумя объектами класса Contacts
        /// </summary>
        /// <returns></returns>
        public Project CreateProject()
        {
            Project project = new Project();
            PhoneNumber phoneOne = new PhoneNumber();
            phoneOne.Number = 71234565432;
            Contact contactOne = new Contact(
                    phoneOne, "Abramov",
                    "Kirill", "ssdsgesd@gmail.com",
                    "sedfh8",
                    new DateTime(1998, 03, 25));
            project.Contacts.Add(contactOne);

            PhoneNumber phoneTwo = new PhoneNumber();
            phoneTwo.Number = 71234567810;
            Contact contact = new Contact(
                phoneOne, "Ivan",
                "Ivanov", "ivan@gmail.com",
                "iVAN",
                new DateTime(1999, 12, 2));
            project.Contacts.Add(contact);
            return project;
        }

        [TestCase("/CorrectVoidContactsData.notes",
            TestName = "Проверка выгрузки некорректного обьекта")]
        [TestCase("2/contacts.json",
            TestName = "Проверка выгрузки по неправильному пути")]
        public void TestProjectManager_LoadFromFile_FileLoadedNull(string filename)
        {
            //Arrange
            var expectedProject = new Project();

            //Act
            var actualProject =
                ProjectManager.LoadFromFile(
                    _projectFileName,
                    filename);

            //Assert
            Assert.AreEqual(
                expectedProject.Contacts.Count,
                actualProject.Contacts.Count);
        }

        [Test(Description = "Проверка выгрузки корректного значения")]
        public void TestProjectManager_LoadFromFile_FileLoadedCorrectly()
        {
            //Arrange
            var expectedProject = CreateProject();

            //Act
            var actualProject =
                ProjectManager.LoadFromFile(
                    _projectFileName,
                    @"\CorrectContactsData.notes");

            //Assert
            Assert.AreEqual(
                expectedProject.Contacts.Count,
                actualProject.Contacts.Count);
            Assert.Multiple(() =>
            {
                for (int index = 0; index < expectedProject.Contacts.Count; index++)
                {
                    var expected = expectedProject.Contacts[index];
                    var actual = actualProject.Contacts[index];

                    Assert.AreEqual(expected, actual);
                }
            }
            );
        }

        [Test(Description = "Проверка сохранения корректного обьекта")]
        public void ProjectManager_SaveCorrectionData_FileSavedCorrectly()
        {
            //SetUp
            var expectedProject = CreateProject();

            //Testing
            ProjectManager.SaveToFile(
                expectedProject,
                _projectFileName);

            //Assert
            var actual =
                File.ReadAllText(_projectFileName + @"\CorrectContactsDataTwo.notes");
            var expected =
                File.ReadAllText(_projectFileName + @"\CorrectContactsData.notes");
            Assert.AreEqual(expected, actual);

        }
    }
}