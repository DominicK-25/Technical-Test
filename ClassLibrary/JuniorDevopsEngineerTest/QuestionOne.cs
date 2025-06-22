namespace JuniorDevopsEngineerTest;

using System;
using System.Collections.Generic;

/*
    Given an array of numbers count the number of elements which appear more than once in the array.

    example:

    numbers = [1,3,3,4,4,4]

    result = 2

    Constraints:
    Min numbers = 3
    Max numbers = 1000

    This means the list or arrays needs to have more than 3 numbers and max 1000
*/
public class QuestionOne
{
    public static int CountDuplicates(List<int> numbers)
    {
        if (numbers.Count < 3 || numbers.Count > 1000)
            throw new ArgumentOutOfRangeException(nameof(numbers));

        HashSet<int> seen = new HashSet<int>();
        HashSet<int> duplicates = new HashSet<int>();

        foreach (int number in numbers)
        {
            if (!seen.Add(number)) // Add return false if number already exist
            {
                duplicates.Add(number);
            }
        }

        return duplicates.Count;
    }
}
