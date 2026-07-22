using DayTwoPuzzle.Converters;
using DayTwoPuzzle.Interfaces;
using DayTwoPuzzle.Tests.MemberData;
using Moq;

namespace DayTwoPuzzle.Tests.Converters
{
    public class StringToArrayConverterTests
    {
        [Theory]
        [MemberData(nameof(MemberDataHelper.TestData), MemberType = typeof(MemberDataHelper))]
        public void ConvertStringTo2DArr_Returns2DArr(string data, int[,] expected)
        {
            // Arrange
            var mock = new Mock<IFileManager>();
            mock.Setup(x => x.ReadFile(It.IsAny<string>())).Returns(data);
            var sut = new StringToArrayConverter(mock.Object);

            // Act
            var results = sut.ConvertStringTo2DArr("dummy.txt");


            // Assert
            Assert.Equal(expected, results);
        }
    }
}
