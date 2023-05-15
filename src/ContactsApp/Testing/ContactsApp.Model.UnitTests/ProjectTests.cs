using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactsApp.Model.UnitTests
{
    public class ProjectTests
    {
        [Test]
        [Description("Позитивный тест геттера Contacts")]
        public void Contacts_GetValues_ReturnsValue()
        {
            // Arrange
            var contactFirst = new Contact();
            var contactSecond = new Contact();
            var expected = new Project();

            // Act
            expected.Contacts.Add(contactFirst);
            expected.Contacts.Add(contactSecond);
            List<Contact> actual = expected.Contacts;

            // Assert
            Assert.AreEqual(expected.Contacts.Count, actual.Count,
                "Количество контактов должно совпадать");
            Assert.Contains(contactFirst, actual,
                "Список контактов не содержит contactFirst");
            Assert.Contains(contactSecond, actual,
                "Список контактов не содержит contactSecond");
        }

        [Test]
        [Description("Позитивный тест сеттера Contacts")]
        public void Contacts_SetValueToList_ValueIsSetted()
        {
            // Arrange
            var contacts = new Project();
            var contact = new Contact();

            // Act
            contacts.Contacts.Add(contact);

            // Assert
            Assert.AreEqual(1, contacts.Contacts.Count,
                "Контакт не добавляется в список контактов");
            Assert.Contains(contact, contacts.Contacts,
                "Список контактов не содержит добавленный контакт");
        }

        [Test]
        [Description("Позитивный тест метода сортировки контактов")]
        public void SortContactsByFullName_SortContacts_ContactsAreSorted()
        {
            // Arrange
            var project = new Project();
            var contactFirst = new Contact { FullName = "Банникова Елизавета" };
            var contactSecond = new Contact { FullName = "Алексеева Дарья" };
            var expected = 1;

            // Act
            var actual = project.SortContactsByFullName(contactFirst, contactSecond);

            // Assert
            Assert.AreEqual(expected, actual, 
                "Контакты должны сортироваться");
        }

        [Test]
        [Description("Позитивный тест метода поиска контактов по подстроке")]
        public void FindContactsBySubstring_FindContacts_ContactsFound()
        {
            // Arrange
            var project = new Project();
            var contactFirst = new Contact { FullName = "Nigel Chikuri" };
            var contactSecond = new Contact { FullName = "Matthew Abaio" };
            var substring = "Nigel";
            var expected = "Nigel Chikuri";
            
            // Act
            project.Contacts.Add(contactFirst);
            project.Contacts.Add(contactSecond);
            var actual = project.FindContactsBySubstring(project.Contacts, substring);

            // Assert
            Assert.AreEqual(expected, actual[0].FullName, 
                "Найденные контакты должны соответствовать условию");
        }

        [Test]
        [Description("Позитивный тест метода поиска контактов с днём рождения")]
        public void FindContactsOfBirthdayPeople_FindContacts_ContactsFound()
        {
            // Arrange
            var project = new Project();
            var dateOfBirth = DateTime.Now.ToShortDateString();
            var contact = new Contact { FullName = "Ilya", DateOfBirth = DateTime.Parse(dateOfBirth) };
            var expected = "Ilya";

            // Act
            project.Contacts.Add(contact);
            var actual = project.FindContactsOfBirthdayPeople(project.Contacts);

            // Assert
            Assert.AreEqual(expected, actual,
                "Найденный контакт с днём рождения не совпадает с искомым");
        }
    }
}
