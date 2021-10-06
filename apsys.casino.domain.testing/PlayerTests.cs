using NUnit.Framework;

namespace apsys.casino.domain.testing
{
    class PlayerTests : UnitaryTestBase<Player>
    {
        [Test]
        public void IsValid_ValidInstance_ReturnTrue()
        {
            // Arrange
            // ... nothing code
            // Act and Assert
            Assert.IsTrue(ClassUnderTest.IsValid());
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("a")]
        [TestCase("a  ")]
        [TestCase("a b")]
        [TestCase("ab ")]
        [TestCase(" ab")]
        [TestCase("  ab")]
        [TestCase("---")]
        [TestCase("- -")]
        [TestCase("01a")]
        [TestCase(" abc ")]
        [TestCase(" abc")]
        public void IsValid_InvalidNickName_ReturnFalse(string nickName)
        {
            // Arrange
            ClassUnderTest.NickName = nickName;
            // Act and Assert
            Assert.IsFalse(ClassUnderTest.IsValid());
        }

        [TestCase("ab")]
        [TestCase("abc")]
        [TestCase("abc ")]
        [TestCase("a01")]
        [TestCase("pepe")]
        public void IsValid_ValidNickName_ReturnTrue(string nickName)
        {
            // Arrange
            ClassUnderTest.NickName = nickName;
            // Act and Assert
            Assert.IsTrue(ClassUnderTest.IsValid());
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(10)]
        public void IsValid_ValidCredits_ReturnTrue(int credits)
        {
            // Arrange
            ClassUnderTest.Credits = credits;
            // Act
            bool result = ClassUnderTest.IsValid();
            // Assert
            Assert.IsTrue(result);
        }

        [TestCase(-1)]
        [TestCase(-10)]
        public void IsValid_InvalidCredits_ReturnFalse(int credits)
        {
            //Arrange
            ClassUnderTest.Credits = credits;
            //Act
            bool result = ClassUnderTest.IsValid();
            //Assert
            Assert.IsFalse(result);
        }
    }
}
