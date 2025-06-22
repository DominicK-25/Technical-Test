using JuniorDevopsEngineerTest;

namespace ClassLibraryTest;

public class QuestionTwoTests
{
    [Fact]
    public void InputInAlphabeticalOrderIsReversedToAlphabeticallyLargest()
    {
        Assert.Equal("fedcba", QuestionTwo.GetLargestString("abcdef", 2));
    }

    [Fact]
    public void InputWhichIsImpossibleToMeetTheConstraintRemovesCharacter()
    {
        Assert.Equal("zzazz", QuestionTwo.GetLargestString("azzzzz", 2));
    }

    [Fact]
    public void InputWhichRequiresReorderNonAlphabeticallyLargestToUseAllCharacters()
    {
        Assert.Equal("zzxxax", QuestionTwo.GetLargestString("azzxxx", 2));
    }

    [Fact]
    public void WhenOneIsConstantOutPutOptimalResponse()
    {
        Assert.Equal("zyzyzvuvup", QuestionTwo.GetLargestString("yuzzvuyzpv", 1));
    }

    [Fact]
    public void LargerExampleAndLargerConstantTest()
    {
        Assert.Equal(
            "zzzzyzzzzyzzzzyzzzzyyyyxyyyxxxxwxxxxwxxwwwwvvvvuqo",
            QuestionTwo.GetLargestString("zxzuvozyzvzywvxyqxzxzyywyxwyzxxwzwzyzzzzyxzvzxxywx", 4)
        );
    }
}
