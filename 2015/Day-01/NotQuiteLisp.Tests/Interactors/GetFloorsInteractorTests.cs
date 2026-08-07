using AoC.Shared;
using Moq;
using NotQuiteLisp.Interactors;

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
            var fileReaderMock = new Mock<IFileReader>();
            fileReaderMock.Setup(x => x.ReadAsString(It.IsAny<string>()))
                .Returns(data);

            var sut = new GetFloorsInteractor(fileReaderMock.Object);

            var result = sut.Handle("ignored.txt");

            Assert.Equal(expectedFloor, result);
        }
    }
}
