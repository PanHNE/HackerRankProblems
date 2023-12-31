﻿/*
    You are in charge of the cake for a child's birthday.
    You have decided the cake will have one candle for each year of their total age.
    They will only be able to blow out the tallest of the candles. Count how many candles are tallest.

    Example
    
    candles = [4, 4, 1, 3]

    The maximum height candles are  units high. There are  of them, so return .

    Function Description

    Complete the function birthdayCakeCandles in the editor below.

    birthdayCakeCandles has the following parameter(s):
        * int candles[n]: the candle heights
        
    Returns:
        *int: the number of candles that are tallest
        
    Input Format

    The first line contains a single integer, n, the size of candles[].
    The second line contains  space-separated integers, where each integer  describes the height of candles[i].

    Constraints:
        * 1 <= n <= 10^5
        * 1 <= candles[i] <= 10^7
 
*/
using BirthdayCakeCandles;

Console.WriteLine("Birthday cake candles");

List<int> candles = new List<int> { 1, 2, 3, 3 };

int result = Solution.BirthdayCakeCandles(candles);

Console.WriteLine(String.Join("result: ", result));
