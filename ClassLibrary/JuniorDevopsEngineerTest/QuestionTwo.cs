namespace JuniorDevopsEngineerTest;

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
/*
    Given a string, construct a new string by rearranging the original string and deleting characters as needed.
    Return the alphabetically largest string that can be constructed respecting a limit as to how many consecutive characters can be the same.
    
    Alphabetically largest - this is when you compare strings z > a = true

    example:

    s = 'baccc'
    k = 2

    result = 'ccbca'

    The largest string, alphabetically, is 'cccba' but it is not allowed because 'c' appears more than k times consecutively.
    Therefor the result is 'ccbca'.

    Constraints:
    The string can only contain lowercase english letters.
    Max length of s is 10^5.
    Max of k 10^3.

    My Notes:
    Construct new string
    Rearrange Original string and delete characters if necessary
    Return the alphabetically largest string so Z > A
    Limit of consecutive characters and that is more than 2 (K = 2)

*/
public class QuestionTwo
{
    public static string GetLargestString(string s, int k)
    {
        //Validate constraints

        if (s.Length > 100000)
            throw new ArgumentOutOfRangeException(nameof(s), "String exceeds maximum length of 100000.");


        if (k < 1 || k > 1000)
            throw new ArgumentOutOfRangeException(nameof(k), "k must be between 1 and 1000.");


        if (s.Any(c => c < 'a' || c > 'z'))
            throw new ArgumentException("String must contain only lowercase English letters.");

        // Count character frequencies 
        Dictionary<char, int> freq = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (!freq.ContainsKey(c))
                freq[c] = 0;
            freq[c]++;
        }

        // Use a descending sorted dictionary 
        // Key is character and Value is character count
        SortedDictionary<char, int> sorted = new SortedDictionary<char, int>(Comparer<char>.Create((a, b) => b.CompareTo(a)));
        foreach (var pair in freq)
        {
            sorted[pair.Key] = pair.Value;
        }

        StringBuilder result = new StringBuilder();

        // Build new string (greedy method)
        while (sorted.Count > 0)
        {
            var first = sorted.First(); // largest char availabile
            char ch = first.Key;
            int count = first.Value;

            //Chooses the smallest number out of k and count
            int use = Math.Min(k, count);
            result.Append(new string(ch, use)); // adds character to result string repeated use times
            sorted.Remove(ch); // removes character from dictionary

            if (count > k)
            {
                // Need to lower char to break repition
                if (sorted.Count == 0)
                    break; // can't break sequence, stop

                var next = sorted.First(); // next largest char
                char nextCh = next.Key;
                result.Append(nextCh);

                //Update next char count
                if (next.Value == 1)
                    sorted.Remove(nextCh);
                else
                    sorted[nextCh] = next.Value - 1;

                //Re-inset original char with remain count
                sorted[ch] = count - use;
            }
        }

        return result.ToString();
    }
}
    