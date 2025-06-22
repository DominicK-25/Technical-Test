using JuniorDevopsEngineerTest;

namespace ClassLibraryTest;

// run the failing test and have the correct result posted on the console
public class CountDuplicatesTest
{
    [Fact]
    public void ZeroIsReturnedWhenNoDuplicates()
    {
        var numbers = new List<int> { 1, 2, 3 };
        int result = QuestionOne.CountDuplicates(numbers);

        Console.WriteLine($"[Test 1] Result: {result}");

        Assert.Equal(0, result);
    }

    [Fact]
    public void OneIsReturnedWhenOneDuplicate()
    {
        var numbers = new List<int> { 1, 2, 3, 1 };
        int result = QuestionOne.CountDuplicates(numbers);

        Console.WriteLine($"[Test 2] Result: {result}");

        Assert.Equal(1, result);
    }

    [Fact]
    public void ListContainsTwoDuplicates()
    {
        var numbers = new List<int> { 8, 1, 3, 1, 4, 5, 6, 3 };
        int result = QuestionOne.CountDuplicates(numbers);

        Console.WriteLine($"[Test 3] Result: {result}");

        Assert.Equal(2, result);
    }

    [Fact]
    public void ListContainsThreeDuplicates()
    {
        var numbers = new List<int> { 9, 9, 1, 4, 3, 1, 6, 6 };
        int result = QuestionOne.CountDuplicates(numbers);

        Console.WriteLine($"[Test 4] Result: {result}");

        Assert.Equal(3, result);
    }

    [Fact]
    public void ThrowsExceptionWhenTooShort()
    {
        var numbers = new List<int> { 1, 2 };
        var except = Assert.Throws<ArgumentOutOfRangeException>(() =>
            QuestionOne.CountDuplicates(numbers));

        Console.WriteLine($"[Test 5: TooShort] Exception caught: {except.Message}");
    }


}
