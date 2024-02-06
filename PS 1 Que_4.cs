/*
 [4] Write a program in C# Sharp to separate odd and even integers in separate arrays.
 */

using System;

class que4
{
    static void Main()
    {
        Console.Write("Input the elements which you want to store in the array: ");
        int nums = Convert.ToInt32(Console.ReadLine());

        int[] inputArray = new int[nums];

        for (int i = 0; i < nums; i++)
        {
            Console.Write($"Enter array element of your choice :- {i}: ");
            inputArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        //odd and even elements after separation
        int[] evenArray = new int[nums];
        int[] oddArray = new int[nums];

        int evenCount = 0;
        int oddCount = 0;

        foreach (int num in inputArray)
        {
            if (num % 2 == 0)
            {
                evenArray[evenCount++] = num;
            }
            else
            {
                oddArray[oddCount++] = num;
            }
        }

        // actual array that user has enetered
        Console.Write("The Original array is: ");
        foreach (int num in inputArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // all the odd elements in the array
        Console.Write("The Odd elements array is: ");
        for (int i = 0; i < oddCount; i++)
        {
            Console.Write(oddArray[i] + " ");
        }
        Console.WriteLine();

        // all the even elements in the array
        Console.Write("The Even elements array is: ");
        for (int i = 0; i < evenCount; i++)
        {
            Console.Write(evenArray[i] + " ");
        }
        Console.WriteLine();
    }
}