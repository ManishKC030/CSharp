// In C#, there are 3 main types of array
// 1. Single-Dimensional Array
// 2. Multi-Dimensional Array
// 3. Jagged Array (Array of Array)

using System;
class ArrayTypes
{
    static void Main()
    {
        //single dimensional array
        int[] number = { 1, 2, 3 };
        Console.WriteLine(number[0]); //output: 1

        //multi dimensional Array uses multiple indexes
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine(matrix[1, 2]); // Output: 6
        Console.WriteLine(matrix[0,1]); //output is 2


    }
}
