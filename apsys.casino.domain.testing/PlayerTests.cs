using NUnit.Framework;

namespace apsys.casino.domain.testing
{
    class PlayerTests
    {
        internal Player ClassUnderTest { get; set; }

        [Test]
        public void IsValid_ValidInstance_ReturnTrue()
        {
            // Arrange
            ClassUnderTest = new Player();
            ClassUnderTest.SetMockData();
            // Act and Assert
            Assert.IsTrue(ClassUnderTest.IsValid());
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("a")]
        [TestCase("a  ")]
        [TestCase("ab")]
        [TestCase("ab ")]
        [TestCase(" ab")]
        [TestCase("  ab")]
        public void IsValid_InvalidNickName_ReturnFalse(string nickName)
        {
            // Arrange
            ClassUnderTest = new Player();
            ClassUnderTest.SetMockData();
            ClassUnderTest.NickName = nickName;
            // Act and Assert
            Assert.IsFalse(ClassUnderTest.IsValid());
        }

    }
}
