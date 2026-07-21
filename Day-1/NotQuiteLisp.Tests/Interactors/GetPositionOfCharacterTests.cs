using Moq;
using NotQuiteLisp.Interactors;
using NotQuiteLisp.Interfaces;

namespace NotQuiteLisp.Tests.Interactors
{
    public class GetPositionOfCharacterInteractorTests
    {
        [Theory]
        [InlineData(")", 1)]
        [InlineData("()())", 5)]
        [InlineData("())", 3)]
        public void Handle_ReturnsPositionOfTheCharacterThatCausesSantaToFirstEnterTheBasement(string data, int expectedPosition)
        {
            // Arrange
            var fileManagerMock = new Mock<IFileManager>();
            fileManagerMock.Setup(x => x.ReadFile(It.IsAny<string>())).Returns(data);
            var sut = new GetPositionOfCharacterInteractor(fileManagerMock.Object);

            // Act
            var result = sut.Handle("ignore.txt");

            // Assert
            Assert.Equal(expectedPosition, result);

        }
    }
}
