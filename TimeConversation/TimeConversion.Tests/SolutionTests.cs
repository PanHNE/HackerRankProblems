namespace TimeConversion.Tests;
using FluentAssertions;

public class SolutionTests
{
    public static IEnumerable<object[]> GetSampleData()
    {
        yield return new object[]
        {
            "11:59:30AM",
            "11:59:30"
        };
        yield return new object[]
        {
            "11:59:30PM",
            "23:59:30"
        };
        yield return new object[]
        {
            "12:00:00AM",
            "00:00:00"
        };
        yield return new object[]
        {
            "12:00:00PM",
            "12:00:00"
        };
        yield return new object[]
        {
            "12:00:01AM",
            "00:00:01"
        };
        yield return new object[]
        {
            "12:00:01PM",
            "12:00:01"
        };
        yield return new object[]
        {
            "07:45:30AM",
            "07:45:30"
        };
        yield return new object[]
        {
            "07:45:30PM",
            "19:45:30"
        };
    }

    [Theory]
    [MemberData(nameof(GetSampleData))]
    public void TimeConversion_GiveTimeInAM_PM_Format_ReturnStringWithMilitaryTime(string input, string output)
    {
        // act
        var resultConversion = Solution.TimeConversion(input);

        // assert
        resultConversion.Should().Be(output);
    }
}