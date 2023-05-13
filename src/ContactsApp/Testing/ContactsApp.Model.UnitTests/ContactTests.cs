using NUnit.Framework;
using System;

namespace ContactsApp.Model.UnitTests
{
    [TestFixture]
    public class ContactTests
    {
        [Test]
        [Description("Позитивный тест геттера FullName")]
        public void FullName_GetValue_ReturnsValue()
        {
            // Arrange
            var contact = new Contact();
            var expected = "Манаков Никита Артемович";
            contact.FullName = expected;

            // Act
            var actual = contact.FullName;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер FullName" +
                " возвращает неправильное полное имя");
        }

        [Test]
        [Description("Позитивный тест сеттера FullName с установкой заглавных букв")]
        public void FullName_SetCorrectValue_ReturnsTitleCaseValue()
        {
            // Arrange
            var contact = new Contact();
            var correctFullName = "little hope";
            var correctFullNameToTitle = "Little Hope";
            var expected = correctFullNameToTitle;

            // Act
            contact.FullName = correctFullName;
            var actual = contact.FullName;

            // Assert
            Assert.AreEqual(expected, actual, "Сеттер должен устанавливать " +
                "FullName в TitleCase");
        }

        [Test]
        [Description("Позитивный тест сеттера FullName при ValidateFullName," +
            " устанавливающем 'Empty Name' если string.Empty")]
        public void FullName_SetEmptyValue_EmptyNameIsSetted()
        {
            // Arrange
            var contact = new Contact();
            var correctFullName = string.Empty;
            var expected = "Empty Name";

            // Act
            contact.FullName = correctFullName;
            var actual = contact.FullName;

            // Assert
            Assert.AreEqual(expected, actual, "Сеттер должен устанавливать 'Empty Name'");
        }

        [Test]
        [Description("Присвоение неправильного FullName длиннее 100 символов")]
        public void FullName_SetTooLongValue_ThrowException()
        {
            // Arrange
            var wrongFullName = "Манаков-Манаков-Манаков-Манаков-Манаков-Манаков-Манаков-" +
                "Манаков-Манаков-Манаков-Манаков-Манаков-Манаков-Манаков-Манаков-Манаков-Манаков";
            var contact = new Contact();

            // Act & Assert
            Assert.Throws<ArgumentException>(
                () => { contact.FullName = wrongFullName; },
                "Должно возникать исключение, если FullName длиннее 100 символов");
        }

        [Test]
        [Description("Позитивный тест геттера Email")]
        public void Email_GetValue_ReturnsValue()
        {
            // Arrange
            var contact = new Contact();
            var expected = "nnmanakovv@gmail.com";
            contact.Email = expected;

            // Act
            var actual = contact.Email;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер Email" +
                " возвращает неправильный e-mail");
        }

        [Test]
        [Description("Позитивный тест сеттера Email")]
        public void Email_SetCorrectValue_ValueIsSetted()
        {
            // Arrange
            var contact = new Contact();
            var correctEmail = "nnmanakovv@gmail.com";
            var expected = correctEmail;

            // Act
            contact.Email = correctEmail;
            var actual = contact.Email;

            // Assert
            Assert.AreEqual(expected, actual, "Сеттер должен устанавливать E-mail");
        }

        [Test]
        [Description("Присвоение неправильного Email длиннее 100 символов")]
        public void Email_SetTooLongValue_ThrowException()
        {
            // Arrange
            var wrongEmail = "nnmanakovv@gmail.com-nnmanakovv@gmail.com-nnmanakovv@gmail.com-" +
                "nnmanakovv@gmail.com-nnmanakovv@gmail.com-nnmanakovv@gmail.com";
            var contact = new Contact();

            // Act & Assert
            Assert.Throws<ArgumentException>(
                () => { contact.Email = wrongEmail; },
                "Должно возникать исключение, если Email длиннее 100 символов");
        }

        [Test]
        [Description("Позитивный тест геттера PhoneNumber")]
        public void PhoneNumber_GetValue_ReturnsValue()
        {
            // Arrange
            var contact = new Contact();
            var expected = "+7 (950) 271-75-71";
            contact.PhoneNumber = expected;

            // Act
            var actual = contact.PhoneNumber;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер PhoneNumber" +
                " возвращает неправильный номер телефона");
        }

        [Test]
        [Description("Позитивный тест геттера PhoneNumber при " +
            "значении по умолчанию")]
        public void PhoneNumber_GetValue_ReturnsDefaultValue()
        {
            // Arrange
            var contact = new Contact();
            var expected = "+7 (000) 000-00-00";
            contact.PhoneNumber = expected;

            // Act
            var actual = contact.PhoneNumber;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер PhoneNumber" +
                " возвращает неправильный номер телефона");
        }

        [TestCase("79502717571", "Должна присваиваться строка, содержащая в себе 11 цифр " +
            "и начинающаяся с '7'",
            TestName = "Присвоение строки с 11-ю цифрами, начинающейся с '7' " +
            "в качестве номера телефона")]
        [TestCase("89502717571", "Должна присваиваться строка, содержащая в себе 11 цифр " +
            "и начинающаяся с '8'",
            TestName = "Присвоение строки с 11-ю цифрами, начинающейся с '8' " +
            "в качестве номера телефона")]
        [TestCase("+79502717571", "Должна присваиваться строка, содержащая в себе 12 цифр " +
            "и начинающаяся с '+7'",
            TestName = "Присвоение строки с 12-ю цифрами, начинающейся с '+7' " +
            "в качестве номера телефона")]
        [TestCase("+7-(950)-271-75-71", "Должна присваиваться строка с регулярным выражением",
            TestName = "Присвоение строки с регулярным выражением типа +7 (XXX) XXX-XX-XX" +
            "в качестве номера телефона")]
        public void PhoneNumber_SetCorrectValue_ValueIsSetted(string correctPhoneNumber,
            string message)
        {
            // Arrange
            var contact = new Contact();
            var correctPhoneNumberFormatted = "+7 (950) 271-75-71";
            var expected = correctPhoneNumberFormatted;

            // Act
            contact.PhoneNumber = correctPhoneNumber;
            var actual = contact.PhoneNumber;

            // Assert
            Assert.AreEqual(expected, actual, message);
        }

        [TestCase("795027175710", "Должно возникать исключение, если номер" +
            " - длиннее 11 символов",
            TestName = "Присвоение строки длиннее 11 символов в качестве номера")]
        [TestCase("09502717571", "Должно возникать исключение, если номер" +
            " - начинается не с той цифры",
            TestName = "Присвоение строки, начинающейся не с '7', '8' или '+7'" +
            " в качестве номера")]
        [TestCase("095027175710", "Должно возникать исключение, если номер" +
            " - длиннее 11 символов и начинается не с той цифры",
            TestName = "Присвоение строки длиннее 11 символов и начинающейся не " +
            "с '7', '8' или '+7' в качестве номера")]
        public void PhoneNumber_SetUncorrectValue_ThrowException(string wrongPhoneNumber, string message)
        {
            // Arrange
            var contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(
                () => { contact.PhoneNumber = wrongPhoneNumber; },
                message);
        }

        [Test]
        [Description("Позитивный тест геттера DateOfBirth")]
        public void DateOfBirth_GetValue_ReturnsValue()
        {
            // Arrange
            var contact = new Contact();
            var expected = new DateTime(2002, 02, 02);
            contact.DateOfBirth = expected;

            // Act
            var actual = contact.DateOfBirth;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер DateOfBirth" +
                " возвращает неправильную дату рождения");
        }

        [Test]
        [Description("Позитивный тест сеттера DateOfBirth при ValidateDateOfBirth," +
            " устанавливающем 0001.01.01 если ничего не введено")]
        public void DateOfBirth_SetCorrectValue_DefaultValueIsSetted()
        {
            // Arrange
            var contact = new Contact();
            var correctDateOfBirth = new DateTime(0001, 01, 01);
            var correctDateOfBirthFormatted = new DateTime(1900, 01, 01);
            var expected = correctDateOfBirthFormatted;

            // Act
            contact.DateOfBirth = correctDateOfBirth;
            var actual = contact.DateOfBirth;

            // Assert
            Assert.AreEqual(expected, actual, "Сеттер должен устанавливать DateTime(1900,01,01)" +
                " в качестве даты рождения");
        }

        [Test]
        [Description("Позитивный тест сеттера DateOfBirth")]
        public void DateOfBirth_SetCorrectValue_ValueIsSetted()
        {
            // Arrange
            var contact = new Contact();
            var correctDateOfBirth = new DateTime(2020, 04, 12);
            var expected = correctDateOfBirth;

            // Act
            contact.DateOfBirth = correctDateOfBirth;
            var actual = contact.DateOfBirth;

            // Assert
            Assert.AreEqual(expected, actual, "Сеттер должен устанавливать DateOfBirth");
        }

        [TestCase("2050-10-10", "Должно возникать исключение, если дата больше текущей",
            TestName = "Присвоение строки, которая при преобразовании в дату будет " +
            "больше текущей")]
        [TestCase("1800-10-10", "Должно возникать исключение, если дата меньше 1900-01-01",
            TestName = "Присвоение строки, которая при преобразовании в дату будет " +
            "меньше 1900-01-01")]
        public void DateOfBirth_SetUncorrectValue_ThrowException(string correctDateOfBirth,
            string message)
        {
            // Arrange
            var contact = new Contact();

            // Assert
            Assert.Throws<ArgumentException>(
                () => { contact.DateOfBirth = DateTime.Parse(correctDateOfBirth); },
                message);
        }

        [Test]
        [Description("Позитивный тест сеттера VkId")]
        public void VkId_SetCorrectValue_ValueIsSetted()
        {
            // Arrange
            var contact = new Contact();
            var correctVkId = "vk.com/nnmanakovv";
            var expected = correctVkId;

            // Act
            contact.VKID = correctVkId;
            var actual = contact.VKID;

            // Assert
            Assert.AreEqual(expected, actual, "Сеттер должен устанавливать VkId");
        }

        [Test]
        [Description("Присвоение неправильного VkId длиннее 50 символов")]
        public void VkId_SetTooLongValue_ThrowException()
        {
            // Arrange
            var wrongVkId = "vk.com/nnmanakovv-vk.com/nnmanakovv-vk.com/nnmanakovv-" +
                "vk.com/nnmanakovv-vk.com/nnmanakovv-vk.com/nnmanakovv";
            var contact = new Contact();

            // Act & Assert
            Assert.Throws<ArgumentException>(
                () => { contact.VKID = wrongVkId; },
                "Должно возникать исключение, если Email длиннее 100 символов");
        }

        [Test]
        [Description("Создание пустого объекта класса Contact")]
        public void Contact_ConstructEmptyObject_ObjectIsBuilt()
        {
            //Act
            var contact = new Contact();

            //Assert
            Assert.IsNotNull(contact, "Объект класса Contact должен создаваться пустым");
        }

        [Test]
        [Description("Создание объекта класса Contact")]
        public void Contact_ConstructObject_ObjectIsBuilt()
        {
            //Arrange
            string correctFullName = "Manakov Nikita";
            string correctEmail = "nnamanakovv@gmail.com";
            string correctPhoneNumber = "+7 (950) 271-75-71";
            DateTime correctDateOfBirth = new DateTime(2002,10,18);
            string correctVkId = "vk.com/nnmanakovv";

            //Act
            var actual = new Contact(
                correctFullName, 
                correctEmail, 
                correctPhoneNumber, 
                correctDateOfBirth, 
                correctVkId
            );

            //Assert
            Assert.AreEqual(correctFullName, actual.FullName, 
                "Должно устанавливаться корректное FullName");
            Assert.AreEqual(correctEmail, actual.Email,
                "Должен устанавливаться корректный Email");
            Assert.AreEqual(correctPhoneNumber, actual.PhoneNumber,
                "Должен устанавливаться корректный PhoneNumber");
            Assert.AreEqual(correctDateOfBirth, actual.DateOfBirth,
                "Должна устанавливаться корректная DateOfBirth");
            Assert.AreEqual(correctVkId, actual.VKID,
                "Должен устанавливаться корректный VkId");
        }

        [Test]
        [Description("Клонирование объекта класса Contact")]
        public void Contact_CloneObject_ObjectIsCloned()
        {
            //Arrange
            string correctFullName = "Manakov Nikita";
            string correctEmail = "nnamanakovv@gmail.com";
            string correctPhoneNumber = "+7 (950) 271-75-71";
            DateTime correctDateOfBirth = new DateTime(2002, 10, 18);
            string correctVkId = "vk.com/nnmanakovv";
            var expected = new Contact(
                correctFullName,
                correctEmail,
                correctPhoneNumber,
                correctDateOfBirth,
                correctVkId
            );

            //Act
            var actual = (Contact)expected.Clone();

            //Assert
            Assert.IsNotNull(actual,
                "Склонированный контакт не должен быть равен null");
            Assert.AreNotSame(expected, actual, 
                "Склонированный контакт должен совпадать с оригиналом");
            Assert.AreEqual(expected.FullName, actual.FullName,
                "Должно клонироваться корректное FullName");
            Assert.AreEqual(expected.Email, actual.Email,
                "Должен клонироваться корректный Email");
            Assert.AreEqual(expected.PhoneNumber, actual.PhoneNumber,
                "Должен клонироваться корректный PhoneNumber");
            Assert.AreEqual(expected.DateOfBirth, actual.DateOfBirth,
                "Должна клонироваться корректная DateOfBirth");
            Assert.AreEqual(expected.VKID, actual.VKID,
                "Должен клонироваться корректный VkId");
        }
    }
}
