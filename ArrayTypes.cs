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
        //multi dimentsional array is in grid/table structure
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine(matrix[1, 2]); // Output: 6
        Console.WriteLine(matrix[0,1]); //output is 2


        // Jagged Array can have different number of elements 
        //Jagged Array is useful for irregular data structures

        //syntax: datatype[][] ArrayName = new datatype[rows][];
        char[][] jArray = new char[3][];
        jArray[0] = new char[] { 'A', 'B', 'C' };
        jArray[1] = new char[] { 'X', 'Y' };
        jArray[2] = new char[]{ 'a', 'b', 'c' };

        Console.WriteLine(jArray[0][1]); // Output: B
        Console.WriteLine(jArray[2][2]); // Output: c


    }
}
