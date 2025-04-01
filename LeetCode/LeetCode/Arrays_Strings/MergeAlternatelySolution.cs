namespace LeetCode.Arrays_Strings;

/*
 You are given two strings word1 and word2. Merge the strings by adding letters in alternating order,
 starting with word1. If a string is longer than the other, append the additional
 letters onto the end of the merged string.
 Return the merged string.

Example :
Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r
 */

public class MergeAlternatelySolution
{
    public string MergeAlternately(string word1, string word2)
    {
        var lengthWord1 = word1.Length;
        var lengthWord2 = word2.Length;
        int i = 0, j = 0;
        var result = "";
        while (i < lengthWord1 || j < lengthWord2)
        {
            if (i < lengthWord1)
            {
                result = result + word1[i++];
            }

            if (j < lengthWord2)
            {
                result = result + word2[j++];
            }
        }

        return result;
    }
}