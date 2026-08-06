using Moq;
using System.Security.Cryptography;
using TheIdealStockingStuffer.Helpers;
using TheIdealStockingStuffer.Interfaces;

namespace TheIdealStockingStuffer.Tests.Helpers
{
    public class GenerateHashHelperTests
    {
        [Theory]
        [InlineData("some_test_string", "83c88c7550d4cd0364b9135343060320")]
        [InlineData("", "d41d8cd98f00b204e9800998ecf8427e")]
        public void GenerateHash_ValidInput_ReturnsHash(string input, string expectedHash)
        {
            // Arrange
            var mock = new Mock<IMdManager>();
            mock.Setup(x => x.CreateHash()).Returns(MD5.Create());
            var sut = new GenerateHashHelper(mock.Object);

            // Act
            var actualHash = sut.GenerateHash(input);

            // Assert
            Assert.NotNull(actualHash);
            Assert.Equal(expectedHash, actualHash);
            Assert.Equal(32, actualHash.Length);
        }

        [Theory]
        [InlineData("", "d41d8cd98f00b204e9800998ecf8427e")]
        public void GenerateHash_EmptyInput_ReturnsHash(string input, string expectedHash)
        {
            // Arrange
            var mock = new Mock<IMdManager>();
            mock.Setup(x => x.CreateHash()).Returns(MD5.Create());
            var sut = new GenerateHashHelper(mock.Object);

            // Act
            var actualHash = sut.GenerateHash(input);

            // Assert
            Assert.NotNull(actualHash);
            Assert.Equal(expectedHash, actualHash);
            Assert.Equal(32, actualHash.Length);
        }

        [Theory]
        [InlineData("string1", "string2")]
        public void GenerateHash_DifferentInputs_ReturnDifferentHashes(string input1, string input2)
        {
            // Arrange
            var mock = new Mock<IMdManager>();
            mock.Setup(x => x.CreateHash()).Returns(MD5.Create());
            var sut = new GenerateHashHelper(mock.Object);

            // Act
            var hash1 = sut.GenerateHash(input1);
            var hash2 = sut.GenerateHash(input2);

            // Assert
            Assert.NotNull(hash1);
            Assert.NotNull(hash2);
            Assert.NotEqual(hash1, hash2);
        }

        [Fact]
        public void GenerateHash_NullInput_ThrowsArgumentNullException()
        {
            // Arrange
            var mock = new Mock<IMdManager>();
            var sut = new GenerateHashHelper(mock.Object);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.GenerateHash(null));
        }
    }
}
