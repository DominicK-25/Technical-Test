using System.Threading.Tasks;
using JuniorDevopsEngineerTest;

namespace ClassLibraryTest;

public class QuestionThreeTests
{
    [Fact]
    public async Task GetsSpidermanMovieTitles()
    {
        Assert.Equal(
            new List<String>
            {
                "Fighting, Flying and Driving: The Stunts of Spiderman 3",
                "Italian Spiderman",
                "Spiderman",
                "Spiderman 5",
                "Spiderman in Cannes",
                "Superman, Spiderman or Batman",
            },
            await QuestionThree.GetMovieTitles("spiderman")
        );
    }

    [Fact]
    public async Task GetsWaterworldMovieTitles()
    {
        Assert.Equal(
            new List<String>
            {
                "The Making of 'Waterworld'",
                "Waterworld",
                "Waterworld",
                "Waterworld",
                "Waterworld 4: History of the Islands",
            },
            await QuestionThree.GetMovieTitles("Waterworld")
        );
    }
}
