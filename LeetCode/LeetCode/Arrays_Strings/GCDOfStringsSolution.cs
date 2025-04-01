namespace LeetCode.Arrays_Strings;

/*
 For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t
 (i.e., t is concatenated with itself one or more times).
Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.

Example1 :
Input: str1 = "ABCABC", str2 = "ABC"
Output: "ABC"

Example 2:
Input: str1 = "LEET", str2 = "CODE"
Output: ""
 */

public class GCDOfStringsSolution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if ((str1 + str2).Equals(str2 + str1))
        {
            return str1.Substring(0, gcd(str1.Length, str2.Length));
        }
        else
        {
            return "";
        }
    }

    private int gcd(int str1, int str2)
    {
        if (str2 == 0)
        {
            return str1;
        }

        return gcd(str2, str1 % str2);
    }
}