using FluentAssertions;

namespace BirthdayCakeCandles.Tests;

public class SolutionTests
{
    public static IEnumerable<object[]> GetSampleData()
    {
        yield return new object[]
        {
            new List<int> { 1, 2, 3, 3 },
            2
        };
        yield return new object[]
        {
            new List<int> { 23, 2, 3, 3 },
            1
        };
        yield return new object[]
        {
            new List<int> { 14324, 2, 3, 3, 14324, 14324, 324, 4235 },
            3
        };
        yield return new object[]
        {
            new List<int> { 201, 2343, 2343, 2343, 5000 },
            1
        };
        yield return new object[]
        {
            new List<int> { 1234, 1, 1, 1, 1234, 1234, 1234, 1234, 1234 },
            6
        };
        yield return new object[]
        {
            new List<int> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            20
        };
    }

    [Theory]
    [MemberData(nameof(GetSampleData))]
    public void BirthdayCakeCandles_ForListOfCandles_ReturnNumberOfTheTallestCandles(List<int> candles, int expectedResult)
    {
        // act
        var actualResult = Solution.BirthdayCakeCandles(candles);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}