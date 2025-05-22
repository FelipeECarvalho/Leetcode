using System;

public Class()
{

    public string MergeAlternately(string word1, string word2)
    {
        int largestWord = word1.Length > word2.Length
            ? word1.Length
            : word2.Length;

        string output = "";

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