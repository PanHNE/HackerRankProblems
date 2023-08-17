namespace CompareTheTriplets.Tests;
using FluentAssertions;

public class ResultTests
{
    public static IEnumerable<object[]> GetSampleData()
    {
        yield return new object[]
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 3, 2, 1 },
            new List<int> { 1, 1 }
        };
        yield return new object[]
        {
            new List<int> { 56, 46, 6 },
            new List<int> { 3, 2, 1 },
            new List<int> { 3, 0 }
        };
        yield return new object[]
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 32, 2, 6 },
            new List<int> { 0, 2 }
        };
        yield return new object[]
        {
            new List<int> { 1, 1, 1 },
            new List<int> { 1, 1, 1 },
            new List<int> { 0, 0 }
        };
        yield return new object[]
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 3, 6, 1 },
            new List<int> { 1, 2 }
        };
    }

    [Theory]
    [MemberData(nameof(GetSampleData))]
    public void compareTriplets(List<int> firstList, List<int> secondList, List<int> expectedResult)
    {
        // act
        List<int> actualResult = Result.CompareTriplets(firstList, secondList);

        // assert
        actualResult.Should().BeEquivalentTo(expectedResult);
    }
}