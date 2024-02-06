/*
 [2_b] Does 'Supercalifragilisticexpialidocious' contain 'ice' as a substring?
 */

using System;

class queb_2
{
    static void Main()
    {
        string letter = "Supercalifragilisticexpialidocious";
        string subLetter = "ice";

        bool containsIce = letter.Contains(subLetter);

        if (containsIce)
        {
            Console.WriteLine("The string has a sub letter 'ice'");
        }
        else
        {
            Console.WriteLine("The string does not have a subletter 'ice'");
        }
    }
}