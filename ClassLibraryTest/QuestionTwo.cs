using System.Runtime.CompilerServices;
using JuniorDevopsEngineerTest;

namespace ClassLibraryTest;

public class QuestionTwoTests
{
    [Fact]
    public void InputInAlphabeticalOrderIsReversedToAlphabeticallyLargest()
    {
        string result = QuestionTwo.GetLargestString("abcdef", 2);
        Console.WriteLine($"[Test 6] Result: {result}");
        Assert.Equal("fedcba", QuestionTwo.GetLargestString("abcdef", 2));
    }

    [Fact]
    public void InputWhichIsImpossibleToMeetTheConstraintRemovesCharacter()
    {
        string result = QuestionTwo.GetLargestString("azzzzz", 2);
        Console.WriteLine($"[Test 7] Result: {result}");
        Assert.Equal("zzazz", result);
    }

    [Fact]
    public void InputWhichRequiresReorderNonAlphabeticallyLargestToUseAllCharacters()
    {
        string result = QuestionTwo.GetLargestString("azzxxx", 2);
        Console.WriteLine($"[Test 8] Result: {result}");
        Assert.Equal("zzxxax", result);
    }

    [Fact]
    public void WhenOneIsConstantOutPutOptimalResponse()
    {
        string result = QuestionTwo.GetLargestString("yuzzvuyzpv", 1);
        Console.WriteLine($"[Test 9] Result: {result}");
        Assert.Equal("zyzyzvuvup", result);
    }

    [Fact]
    public void LargerExampleAndLargerConstantTest()
    {
        string input = "zxzuvozyzvzywvxyqxzxzyywyxwyzxxwzwzyzzzzyxzvzxxywx";
        string expected = "zzzzyzzzzyzzzzyzzzzyyyyxyyyxxxxwxxxxwxxwwwwvvvvuqo";
        string result = QuestionTwo.GetLargestString(input, 4);
        Console.WriteLine($"[Test 10] Result: {result}");
        Assert.Equal(expected, result);
    }

    [Fact]
    public void HandlesVeryLongInputEfficiently()
    {
        // Generate 100,000 characters: mostly 'z' with some 'y' breaks
        string input = new string('z', 99900) + new string('y', 100);
        string result = QuestionTwo.GetLargestString(input, 1000);

        Console.WriteLine($"[Test 11] Result Length: {result.Length}");
        Assert.True(result.Length <= input.Length); // should not exceed original length
    }
    
    [Fact]
    public void AllowsLongRunsWithLargeK()
    {
        string input = "a" + new string('z', 1500) + "b";  // 'z' repeated > k
        string result = QuestionTwo.GetLargestString(input, 1000);

        Console.WriteLine($"[Test 12] Result: {result.Substring(0, 10)}...");
        Assert.DoesNotContain(new string('z', 1001), result); // ensure 'z' never repeats more than 1000
    }


}
