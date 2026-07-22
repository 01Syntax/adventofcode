using DayTwoPuzzle.Interactors;
using DayTwoPuzzle.Interfaces;
using DayTwoPuzzle.Tests.MemberData;
using Moq;

namespace DayTwoPuzzle.Tests.Interactors
{
    public class CalculateAreaInteractorTests
    {
        [Theory]
        [MemberData(nameof(CalculateAreaData.TestData), MemberType = typeof(CalculateAreaData))]
        public void Handle_ReturnsAreaOfTheSmallerSize(int[,] input, int expected)
        {
            // Arrange 
            var mock = new Mock<IArraySorter>();
            mock.Setup(x => x.Sort2DArray(It.IsAny<int[,]>())).Returns(input);
            var sut = new CalculateAreaInteractor(mock.Object);

            // Act
            var actual = sut.Handle(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
