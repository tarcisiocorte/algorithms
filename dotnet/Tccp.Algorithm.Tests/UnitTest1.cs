using System;
using System.Collections.Generic;
using System.IO;
using Tccp.Algorithm.Arrays;
using Tccp.Algorithm.CodeChallenge;
using Tccp.Algorithm.DynamicProgramming;
using Tccp.Algorithm.Recursive;
using Xunit;

namespace Tccp.Algorithm.Tests
{
public class UnitTest1
{
    [Fact]
    public void BinarySearch_FindsExpectedIndex()
    {
        var index = BinarySerach.BinarySearch(new[] { 10, 12, 20, 28, 29, 45, 48, 50 }, 29);
        Assert.Equal(4, index);
    }

    [Fact]
    public void TwoSumWithDictionary_ReturnsPairIndices()
    {
        var result = TwoSum.TwoSumWithDictionary(new[] { 2, 7, 11, 15 }, 9);
        Assert.Equal(new[] { 0, 1 }, result);
    }

    [Fact]
    public void MaxSubArraySum_ReturnsLargestContiguousSum()
    {
        var result = MaxSumSubArray.MaxSubArraySum(new[] { -1, -2, 3, 4, -4, 6, -14, 8, 2 });
        Assert.Equal(10, result);
    }

    [Fact]
    public void LongestSubstringWithoutRepeatingCharacters_ReturnsExpectedLength()
    {
        var result = LongestSubstringWithoutRepeatingCharacters.Execution("abcabcbb");
        Assert.Equal(3, result);
    }

    [Fact]
    public void DynamicArray_ReturnsExpectedAnswers()
    {
        var queries = new List<List<int>>
        {
            new List<int> { 1, 0, 5 },
            new List<int> { 1, 1, 7 },
            new List<int> { 1, 0, 3 },
            new List<int> { 2, 1, 0 },
            new List<int> { 2, 1, 1 }
        };

        var result = DynamicArrays.DynamicArray(2, queries);
        Assert.Equal(new List<int> { 7, 3 }, result);
    }

    [Fact]
    public void GetNthUglyNumber_ReturnsExpectedValue()
    {
        var result = UglyNumber.GetNthUglyNumber(10);
        Assert.Equal(12, result);
    }

    [Fact]
    public void FormulaMethods_WorkAsExpected()
    {
        Assert.Equal(120, Formula.Factorial(5));
        Assert.Equal(6, Formula.GetGreatestCommonDivisor(54, 24));
    }

    [Fact]
    public void MovingTotal_ContainsTracksTripletSums()
    {
        var movingTotal = new Tccp.Algorithm.MovingTotal();
        movingTotal.Append(new[] { 1, 2, 3, 4 });

        Assert.True(movingTotal.Contains(6));
        Assert.True(movingTotal.Contains(9));
        Assert.False(movingTotal.Contains(7));
    }

    [Fact]
    public void TowerOfHanoi_WritesMovesToConsole()
    {
        var originalOut = Console.Out;
        using var writer = new StringWriter();
        Console.SetOut(writer);
        try
        {
            TowerOfHanoi.ExecuteRecursiveTowerOfHanoi(2, 'A', 'C', 'B');
        }
        finally
        {
            Console.SetOut(originalOut);
        }

        var output = writer.ToString();
        Assert.Contains("Move 1 disk from peg A to peg B", output);
        Assert.Contains("Move 2 disk from peg A to peg C", output);
    }
}
}
