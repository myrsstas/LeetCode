namespace LeetCode.Two_Pointers;

/*
 Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
 
A subsequence of a string is a new string that is formed from the original string by deleting 
some (can be none) of the characters without disturbing the relative positions of the 
remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

Example :

Input: s = "abc", t = "ahbgdc"
Output: true
 */

public class IsSubsequenceSolution
{
    public bool IsSubsequence(string s, string t)
    {
        int lengthOfS = s.Length, lengthOfT = t.Length;
        int indexS = 0, indexT = 0;

        while (indexS < lengthOfS && indexT < lengthOfT)
        {
            if (s[indexS] == t[indexT])
            {
                indexS++;
            }

            indexT++;
        }

        return indexS == lengthOfS;
    }
}