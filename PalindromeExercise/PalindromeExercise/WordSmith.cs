using System;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsPalindrome(string word)
    {
        /* var reverse = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reverse += word[i];
        } */
        
        var wordArray = word.ToCharArray();
        Array.Reverse(wordArray);
        var reversed = new string(wordArray);
        //throw new NotImplementedException();
        if (word.ToLower() == reversed.ToLower())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}