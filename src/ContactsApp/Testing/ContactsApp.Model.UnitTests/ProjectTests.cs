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
        [Description("Позитивный тест метода сортировки контактов," +
            " когда список не отсортирован")]
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
        [Description("Позитивный тест метода сортировки контактов," +
            " когда список уже отсортирован")]
        public void SortContactsByFullName_SortedContacts_ContactsAreSorted()
        {
            // Arrange
            var project = new Project();
            var contactFirst = new Contact { FullName = "Алексеева Дарья" };
            var contactSecond = new Contact { FullName = "Банникова Елизавета" };
            var expected = -1;

            // Act
            var actual = project.SortContactsByFullName(contactFirst, contactSecond);

            // Assert
            Assert.AreEqual(expected, actual,
                "Контакты должны быть уже отсортированы");
        }

        [Test]
        [Description("Негативный тест сортировки пустого списка контактов")]
        public void SortContactsByFullName_EmptyContactList_ContactsNotSorted()
        {
            // Arrange
            var project = new Project();
            var contactFirst = new Contact { FullName = "" };
            var contactSecond = new Contact { FullName = "" };
            var expected = 0;

            // Act
            var actual = project.SortContactsByFullName(contactFirst, contactSecond);

            // Assert
            Assert.AreEqual(expected, actual,
                "Сортировка не должна производиться для пустого списка контактов");
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
        [Description("Позитивный тест метода поиска контактов по подстроке," +
            " когда ни один из списка контактов не подошёл")]
        public void FindContactsBySubstring_NoMatchingContacts_EmptyListReturned()
        {
            // Arrange
            var project = new Project();
            var contactFirst = new Contact { FullName = "Nigel Chikuri" };
            var contactSecond = new Contact { FullName = "Matthew Abaio" };
            var substring = "John"; 
            var expectedCount = 0;

            // Act
            project.Contacts.Add(contactFirst);
            project.Contacts.Add(contactSecond);
            var actual = project.FindContactsBySubstring(project.Contacts, substring);

            // Assert
            Assert.AreEqual(expectedCount, actual.Count,
                "Ожидался пустой список контактов, так как ни один контакт не должен подходить");
        }

        [Test]
        [Description("Позитивный тест метода поиска контактов по подстроке," +
            " когда подстрока пустая")]
        public void FindContactsBySubstring_EmptySearchQuery_AllContactsReturned()
        {
            // Arrange
            var project = new Project();
            var contactFirst = new Contact { FullName = "Nigel Chikuri" };
            var contactSecond = new Contact { FullName = "Matthew Abaio" };
            var searchQuery = ""; 
            var expectedCount = 2;

            // Act
            project.Contacts.Add(contactFirst);
            project.Contacts.Add(contactSecond);
            var actual = project.FindContactsBySubstring(project.Contacts, searchQuery);

            // Assert
            Assert.AreEqual(expectedCount, actual.Count,
                "Ожидался возврат всех контактов, так как поисковой запрос не задан");
            Assert.Contains(contactFirst, actual,
                "Ожидалось, что контакт 'Nigel Chikuri' будет возвращен");
            Assert.Contains(contactSecond, actual,
                "Ожидалось, что контакт 'Matthew Abaio' будет возвращен");
        }

        [Test]
        [Description("Позитивный тест метода поиска контактов по подстроке," +
            " когда список контактов пустой")]
        public void FindContactsBySubstring_EmptyContactList_EmptyListReturned()
        {
            // Arrange
            var project = new Project();
            var contactList = new List<Contact>(); 
            var searchQuery = "John";
            var expectedCount = 0;

            // Act
            var actual = project.FindContactsBySubstring(contactList, searchQuery);

            // Assert
            Assert.AreEqual(expectedCount, actual.Count,
                "Ожидался пустой список контактов, так как исходный список контактов пустой");
        }

        [Test]
        [Description("Позитивный тест метода поиска контактов с днём рождения")]
        public void FindContactsOfBirthdayPeople_FindContacts_ContactsFound()
        {
            // Arrange
            var project = new Project();
            var dateOfBirth = DateTime.Now.ToShortDateString();
            var contact = new Contact { FullName = "Ilya", DateOfBirth = 
                DateTime.Parse(dateOfBirth) };
            var expected = "Ilya";

            // Act
            project.Contacts.Add(contact);
            var actual = project.FindContactsOfBirthdayPeople(project.Contacts);

            // Assert
            Assert.AreEqual(expected, actual,
                "Найденный контакт с днём рождения не совпадает с искомым");
        }

        [Test]
        [Description("Позитивный тест метода поиска контактов с днём рождения," +
            " когда ничего не выводится")]
        public void FindContactsOfBirthdayPeople_NotBirthdayContact_NoContactFound()
        {
            // Arrange
            var project = new Project();
            var today = DateTime.Today;
            var contact = new Contact { FullName = "Ilya", DateOfBirth = today.AddDays(-1) }; 
            var expected = string.Empty;

            // Act
            project.Contacts.Add(contact);
            var actual = project.FindContactsOfBirthdayPeople(project.Contacts);

            // Assert
            Assert.AreEqual(expected, actual,
                "Не должен быть найден контакт, так как сегодня не его день рождения");
        }
    }
}
