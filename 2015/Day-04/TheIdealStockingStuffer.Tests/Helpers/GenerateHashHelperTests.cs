namespace TheIdealStockingStuffer.Tests.Helpers
{
    public class GenerateHashHelperTests
    {
        [Fact]
        public void GenerateHash_ValidInput_ReturnsHash()
        {
            // Arrange
            var input = "some_test_string";
            var expectedHashPrefix = "a1b2c3d4e5f6"; // Based on a known SHA256 hash for "some_test_string"

            // Act
            var actualHash = GenerateHashHelper.GenerateHash(input);

            // Assert
            Assert.NotNull(actualHash);
            Assert.StartsWith(expectedHashPrefix, actualHash);
            Assert.Equal(64, actualHash.Length); // SHA256 hash length is 64 characters
        }

        [Fact]
        public void GenerateHash_EmptyInput_ReturnsHash()
        {
            // Arrange
            var input = "";
            var expectedHashPrefix = "e3b0c44298fc"; // Based on a known SHA256 hash for an empty string

            // Act
            var actualHash = GenerateHashHelper.GenerateHash(input);

            // Assert
            Assert.NotNull(actualHash);
            Assert.StartsWith(expectedHashPrefix, actualHash);
            Assert.Equal(64, actualHash.Length);
        }

        [Fact]
        public void GenerateHash_DifferentInputs_ReturnDifferentHashes()
        {
            // Arrange
            var input1 = "string1";
            var input2 = "string2";

            // Act
            var hash1 = GenerateHashHelper.GenerateHash(input1);
            var hash2 = GenerateHashHelper.GenerateHash(input2);

            // Assert
            Assert.NotNull(hash1);
            Assert.NotNull(hash2);
            Assert.NotEqual(hash1, hash2);
        }

        [Fact]
        public void GenerateHash_NullInput_ThrowsArgumentNullException()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => GenerateHashHelper.GenerateHash(null));
        }
    }
}
