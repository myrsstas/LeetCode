namespace LeetCode.Arrays_Strings;

/*

 Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower
and upper cases, more than once.

Example :
Input: s = "IceCreAm"
Output: "AceCreIm"
Explanation:
The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".
 */

public class ReverseVowelsOfAStringSolution
{
    public string ReverseVowels(string s) {
        char [] word = s.ToCharArray();
        int start = 0;
        int end = s.Length-1;
        string vowels="aeiouAEIOU";

        while (start<end){
            while (start<end && !vowels.Contains(word[start].ToString())){
                start++;
            }

            while (start<end && !vowels.Contains(word[end].ToString())){
                end--;
            }

            char temporary = word[start];
            word[start] = word[end];
            word[end] = temporary;

            start++;
            end--;
        }

        return new string(word);
    }
}