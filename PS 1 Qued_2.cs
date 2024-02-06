/*
 [2_d] Which composer comes first in the dictionary: 'Berlioz', 'Borodin', 'Brian', 'Bartok', 'Bellini', 'Buxtehude', 'Bernstein'. Which one comes last?
 */

using System;

class qued_2
{
    static void Main()
    {
        string[] composerDict = { "Berlioz", "Borodin", "Brian", "Bartok", "Bellini", "Buxtehude", "Bernstein" };

        Array.Sort(composerDict);
        Console.WriteLine("First composer in composer dictionary :- " + composerDict[0]);
        Console.WriteLine("Last composer in composer dictionary :- " + composerDict[composerDict.Length - 1]);
    }
}