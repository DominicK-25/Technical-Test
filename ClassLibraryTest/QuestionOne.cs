using JuniorDevopsEngineerTest;

namespace ClassLibraryTest;

public class CountDuplicatesTest
{
    [Fact]
    public void ZeroIsReturnedWhenNoDuplicates()
    {
        Assert.Equal(0, QuestionOne.CountDuplicates(new List<int> { 1, 2, 3 }));
    }

    [Fact]
    public void OneIsReturnedWhenOneDuplicate()
    {
        Assert.Equal(1, QuestionOne.CountDuplicates(new List<int> { 1, 2, 3, 1 }));
    }

    [Fact]
    public void ListContainsTwoDuplicates()
    {
        Assert.Equal(2, QuestionOne.CountDuplicates(new List<int> { 8, 1, 3, 1, 4, 5, 6, 3 }));
    }
}
