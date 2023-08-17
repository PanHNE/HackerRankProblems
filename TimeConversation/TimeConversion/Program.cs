﻿/*
    Given a time in -hour AM/PM format, convert it to military (24-hour) time.

    Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
    - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

    Example:
        * s = 12:01:00PM

        * return '12:01:00'

        * s = 12:01:00AM
        *return '00:01:00'

    Function Description

    Complete the timeConversion function in the editor below. It should return a new string representing the input time in 24 hour format.

    timeConversion has the following parameter(s):

        * string s: a time in  12 hour format
        * 
    Returns:
        * string: the time in  24 hour format
        * 
    Input Format

    A single string  that represents a time in -hour clock format (i.e.: hh:mm:ssAM or hh:mm:ssPM).

    Constraints

    All input times are valid 
 */
using TimeConversion;

Console.WriteLine("Time conversion");

string exampleStringTimeAM = "07:30:23AM";
string resultAM = Solution.TimeConversion(exampleStringTimeAM);
Console.WriteLine($"{exampleStringTimeAM} => {resultAM}");


string exampleStringTimePM = "07:30:23PM";
string resultPM = Solution.TimeConversion(exampleStringTimePM);
Console.WriteLine($"{exampleStringTimePM} => {resultPM}");



