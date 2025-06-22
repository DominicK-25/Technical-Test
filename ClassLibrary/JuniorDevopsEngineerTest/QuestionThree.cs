namespace JuniorDevopsEngineerTest;

/*
    Write a function to fetch and sort movie titles from an API.

    This function should take in a search term substr which should be used as the title param in the api call.

    Libraries can be used to complete this question.

    The result should be an Array of the movie titles.


*/
public class QuestionThree
{
    /*
    * Complete the function below.
    * Base url: https://jsonmock.hackerrank.com/api/moviesdata/search/?Title=<substr>&page<pageNumber>
    */
    public static async Task<string[]> GetMovieTitles(string substr)
    { 
         return await Task.FromResult(new string[0]);  //placeholder for now, logic will added after I work on Q1 and Q2
    }
}
