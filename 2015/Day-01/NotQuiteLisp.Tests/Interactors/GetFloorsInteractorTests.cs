using Moq;
using NotQuiteLisp.Interactors;
using NotQuiteLisp.Interfaces;

namespace NotQuiteLisp.Tests.Interactors
{
    public class GetFloorsInteractorTests
    {
        [Theory]
        [InlineData("(()())", 0)]
        [InlineData("(((", 3)]
        [InlineData("(()(()(", 3)]
        [InlineData("())", -1)]
        public void Handle_GetCorrectSantaFloor(string data, int expectedFloor)
        {
            // Arrange
            var fileManagerMock = new Mock<IFileManager>();
            fileManagerMock.Setup(x => x.ReadFile(It.IsAny<string>()))
                .Returns(data);

            var sut = new GetFloorsInteractor(fileManagerMock.Object);

            // Act
            var result = sut.Handle("ignored.txt");

            // Assert
            Assert.Equal(expectedFloor, result);
        }
    }
}
