/*
 [2_c] Which of the following words is the longest: Supercalifragilisticexpialidocious, Honorificabilitudinitatibus, or Bababadalgharaghtakamminarronnkonn?
 */

using System;

class quec_3
{
    static void Main()
    {
        string str1 = "Supercalifragilisticexpialidocious";
        string str2 = "Honorificabilitudinitatibus";
        string str3 = "Bababadalgharaghtakamminarronnkonn";

        string lngestLetter = FindLongestWord(str1, str2, str3);

        Console.WriteLine("The longest word is :- " + lngestLetter);
    }

    static string FindLongestWord(params string[] words)
    {
        string longestWord = "";

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        return longestWord;
    }
}