namespace Leetcode;

public sealed class MergeAlternately
{
    public static string Solution(string word1, string word2)
    {
        string output = "";
        
        int largestWord = word1.Length > word2.Length
            ? word1.Length
            : word2.Length;

        for (int i = 0; i < largestWord; i++)
        {
            if (i < word1.Length)
            {
                output += word1[i];
            }

            if (i < word2.Length)
            {
                output += word2[i];
            }
        }

        return output;
    }
}