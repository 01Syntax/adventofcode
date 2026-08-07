using AoC.Shared;
using Moq;
using NotQuiteLisp.Interactors;

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
            var fileReaderMock = new Mock<IFileReader>();
            fileReaderMock.Setup(x => x.ReadAsString(It.IsAny<string>())).Returns(data);
            var sut = new GetPositionOfCharacterInteractor(fileReaderMock.Object);

            var result = sut.Handle("ignore.txt");

            Assert.Equal(expectedPosition, result);
        }
    }
}
