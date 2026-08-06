using Moq;
using TheIdealStockingStuffer.Interactors;
using TheIdealStockingStuffer.Interfaces;

namespace TheIdealStockingStuffer.Tests.Interactors
{
    public class GetLowestNumberInteractorTests
    {
        [Theory]
        [InlineData("abcdef", 609043)]
        [InlineData("pqrstuv", 1048970)]
        public void Handle_ReturnsLowestPositiveNumberToProduceHash(string secretKey, int expectedLowestNumber)
        {
            // Arrange
            var mock = new Mock<IGenerateHashHelper>();

            mock.Setup(x => x.GenerateHash(It.IsAny<string>()))
                .Returns((string input) =>
                {
                    if (input == $"{secretKey}{expectedLowestNumber}")
                    {
                        return "00000e80b5017098950fc58aad83c8c14978e";
                    }

                    return "ffffffffffffffffffffffffffffffff";
                });

            var sut = new GetLowestNumberInteractor(mock.Object);

            // Act
            int result = sut.Handle(secretKey);

            // Assert
            Assert.Equal(expectedLowestNumber, result);
        }
    }
}