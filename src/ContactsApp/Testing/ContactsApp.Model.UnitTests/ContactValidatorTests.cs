using NUnit.Framework;
using System;

namespace ContactsApp.Model.UnitTests
{
    [TestFixture]
    public class ContactValidatorTests
    {
        [Test]
        [Description("Позитивный тест валидатора FullName")]
        public void ValidateFullName_CheckCorrectValue_ReturnsTrue()
        {
            // Arrange
            var validator = new ContactValidator();
            var correctFullName = "Сергей Симаков";
            var expected = true;

            // Act
            var actual = validator.ValidateFullName(ref correctFullName, out _);
            
            // Assert
            Assert.AreEqual(expected, actual, "ValidateFullName не должен возвращать false");
        }

        [Test]
        [Description("Позитивный тест валидатора FullName на пустую строку")]
        public void ValidateFullName_CheckCorrectValue_ReturnsPresetValue() 
        {
            // Arrange
            var validator = new ContactValidator();
            var correctFullName = string.Empty;
            var expected = "Empty Name";

            // Act
            var isValid = validator.ValidateFullName(ref correctFullName, out _);
            var actual = correctFullName;

            // Assert
            Assert.IsTrue(isValid);
            Assert.AreEqual(expected, actual, "ValidateFullName не присваивает " +
                "'Empty Name' в переменную");
        }

        [Test]
        [Description("Присвоение неправильного FullName больше 100 символов")]
        public void ValidateFullName_CheckTooLongValue_ThrowsException()
        {
            // Arrange
            var validator = new ContactValidator();
            var wrongFullName = "Я не знаю, сколько символов в этой строке, но она явно " +
                "должна пройти проверку валидатором на неправильное значение";
            var expected = false;

            // Act
            var actual = validator.ValidateFullName(ref wrongFullName, out _);

            // Assert
            Assert.AreEqual(expected, actual, "Должно возникать исключение, " +
                "если FullName длиннее 100 символов");
        }

        [Test]
        [Description("Позитивный тест валидатора Email")]
        public void ValidateEmail_CheckCorrectValue_ReturnsTrue()
        {
            // Arrange
            var validator = new ContactValidator();
            var correctEmail = "nnmanakovv@gmail.com";
            var expected = true;

            // Act
            var actual = validator.ValidateEmail(correctEmail, out _);

            // Assert
            Assert.AreEqual(expected, actual, "ValidateEmail не должен возвращать false");
        }

        [Test]
        [Description("Присвоение неправильного Email больше 100 символов")]
        public void ValidateEmail_CheckTooLongValue_ThrowsException()
        {
            // Arrange
            var validator = new ContactValidator();
            var wrongEmail = "nnmanakovv@gmail.com-nnmanakovv@gmail.com-nnmanakovv@gmail.com" +
                "-nnmanakovv@gmail.com-nnmanakovv@gmail.com";
            var expected = false;

            // Act
            var actual = validator.ValidateEmail(wrongEmail, out _);

            // Assert
            Assert.AreEqual(expected, actual, "Должно возникать исключение, " +
                "если Email длиннее 100 символов");
        }

        [Test]
        [Description("Позитивный тест валидатора PhoneNumber, " +
            "когда PhoneNumber имеет длину 11 символов и начинается с '7'")]
        public void ValidatePhoneNumber_Check11DigitsStartsWith7_ReturnsTrue()
        {
            // Arrange
            var validator = new ContactValidator();
            var correctPhoneNumber = "79502717571";
            var expected = true;

            // Act
            var actual = validator.ValidatePhoneNumber(correctPhoneNumber, out _);

            // Assert
            Assert.AreEqual(expected, actual, "ValidatePhoneNumber не должен возвращать false");
        }

        [Test]
        [Description("Позитивный тест валидатора PhoneNumber, " +
            "когда PhoneNumber имеет длину 12 символов и начинается с '+7'")]
        public void ValidatePhoneNumber_Check12DigitsStartsWith7_ReturnsTrue()
        {
            // Arrange
            var validator = new ContactValidator();
            var correctPhoneNumber = "+79502717571";
            var expected = true;

            // Act
            var actual = validator.ValidatePhoneNumber(correctPhoneNumber, out _);

            // Assert
            Assert.AreEqual(expected, actual, "ValidatePhoneNumber не должен возвращать false");
        }

        [Test]
        [Description("Позитивный тест валидатора PhoneNumber, " +
            "когда PhoneNumber имеет длину 11 символов и начинается с '8'")]
        public void ValidatePhoneNumber_Check11DigitsStartsWith8_ReturnsTrue()
        {
            // Arrange
            var validator = new ContactValidator();
            var correctPhoneNumber = "89502717571";
            var expected = true;

            // Act
            var actual = validator.ValidatePhoneNumber(correctPhoneNumber, out _);

            // Assert
            Assert.AreEqual(expected, actual, "ValidatePhoneNumber не должен возвращать false");
        }

        [Test]
        [Description("Позитивный тест валидатора PhoneNumber регулярным выражением Regex")]
        public void ValidatePhoneNumber_CheckRegex_ReturnsTrue()
        {
            // Arrange
            var validator = new ContactValidator();
            var correctPhoneNumber = "+7 (950) 271-75-71";
            var expected = true;

            // Act
            var actual = validator.ValidatePhoneNumber(correctPhoneNumber, out _);

            // Assert
            Assert.AreEqual(expected, actual, "ValidatePhoneNumber не должен возвращать false");
        }

        [Test]
        [Description("Присвоение неправильного PhoneNumber, где больше 11 цифр")]
        public void ValidatePhoneNumber_CheckTooLongValue_ThrowsException()
        {
            // Arrange
            var validator = new ContactValidator();
            var wrongPhoneNumber = "+7(950)271-75-710";
            var expected = false;

            // Act
            var actual = validator.ValidatePhoneNumber(wrongPhoneNumber, out _);

            // Assert
            Assert.AreEqual(expected, actual, "Должно возникать исключение, " +
                "если в PhoneNumber больше 11 цифр");
        }

        [Test]
        [Description("Присвоение неправильного PhoneNumber, начинающегося не с '7', '+7, '8'")]
        public void ValidatePhoneNumber_CheckValueStartsWithSevenOrEight_ThrowsException()
        {
            // Arrange
            var validator = new ContactValidator();
            var wrongPhoneNumber = "99502717571";
            var expected = false;

            // Act
            var actual = validator.ValidatePhoneNumber(wrongPhoneNumber, out _);

            // Assert
            Assert.AreEqual(expected, actual, "Должно возникать исключение, " +
                "если PhoneNumber начинается не с '7', '+7', '8'");
        }

        [Test]
        [Description("Позитивный тест валидатора DateOfBirth, если значение не было введено " +
            "и равно DateTime(0001, 01, 01)")]
        public void ValidateDateOfBirth_CheckDefaultValue_ReturnsTrue()
        {
            // Arrange
            var validator = new ContactValidator();
            var correctDateOfBirth = new DateTime(0001, 01, 01);
            var expected = true;

            // Act
            var actual = validator.ValidateDateOfBirth(ref correctDateOfBirth, out _);

            // Assert
            Assert.AreEqual(expected, actual, "ValidateDateOfBirth не должен возвращать false");
        }

        [Test]
        [Description("Позитивный тест валидатора DateOfBirth, если значение лежит в пределах" +
            " от DateTime(1900, 01, 01) до DateTime.Now")]
        public void ValidateDateOfBirth_CheckCorrectValue_ReturnsTrue()
        {
            // Arrange
            var validator = new ContactValidator();
            var correctDateOfBirth = new DateTime(2002, 02, 13);
            var expected = true;

            // Act
            var actual = validator.ValidateDateOfBirth(ref correctDateOfBirth, out _);

            // Assert
            Assert.AreEqual(expected, actual, "ValidateDateOfBirth не должен возвращать false");
        }

        [Test]
        [Description("Присвоение неправильного DateOfBirth, когда он больше DateTime.Now")]
        public void ValidateDateOfBirth_CheckValueGreaterThanCurrent_ThrowsException()
        {
            // Arrange
            var validator = new ContactValidator();
            var correctDateOfBirth = new DateTime(2032, 02, 13);
            var expected = false;

            // Act
            var actual = validator.ValidateDateOfBirth(ref correctDateOfBirth, out _);

            // Assert
            Assert.AreEqual(expected, actual, "Должно возникать исключение, " +
                "если DateOfBirth больше DateTime.Now");
        }

        [Test]
        [Description("Присвоение неправильного DateOfBirth, когда он меньше DateTime(1900, 01, 01)")]
        public void ValidateDateOfBirth_CheckValueLessThanMinimum_ThrowsException()
        {
            // Arrange
            var validator = new ContactValidator();
            var correctDateOfBirth = new DateTime(1800, 02, 13);
            var expected = false;

            // Act
            var actual = validator.ValidateDateOfBirth(ref correctDateOfBirth, out _);

            // Assert
            Assert.AreEqual(expected, actual, "Должно возникать исключение, " +
                "если DateOfBirth меньше DateTime(1900, 01, 01)");
        }

        [Test]
        [Description("Позитивный тест валидатора VkId")]
        public void ValidateVkId_CheckCorrectValue_ReturnsTrue()
        {
            // Arrange
            var validator = new ContactValidator();
            var correctVkId = "vk.com/nnmanakovv";
            var expected = true;

            // Act
            var actual = validator.ValidateVkId(correctVkId, out _);

            // Assert
            Assert.AreEqual(expected, actual, "ValidateVkId не должен возвращать false");
        }

        [Test]
        [Description("Присвоение неправильного VkId больше 50 символов")]
        public void ValidateVkId_CheckTooLongValue_ThrowsException()
        {
            // Arrange
            var validator = new ContactValidator();
            var wrongVkId = "Я не знаю, сколько символов в этой строке, но она явно " +
                "должна пройти проверку валидатором на неправильное значение";
            var expected = false;

            // Act
            var actual = validator.ValidateVkId(wrongVkId, out _);

            // Assert
            Assert.AreEqual(expected, actual, "Должно возникать исключение, " +
                "если VkId длиннее 50 символов");
        }
    }
}
