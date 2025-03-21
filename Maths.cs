using System;

  class Maths
{
    static void Main()
    {
        // c# has many method that allows to perform mathematical tasks
        Console.WriteLine(Math.Max(7, 8)); //output is 8
        Console.WriteLine(Math.Min(5,4)); //output is 4
        Console.WriteLine(Math.Sqrt(49)); //gives squareroot.
        Console.WriteLine(Math.Abs(-2.3)); //gives absolute value i.e. 2.3
        Console.WriteLine(Math.Round(11.5)); //rounds the number

        /* Simple Fact about Rounding number that end in .5 in C#
         * if number is even, round down 
         * if number is odd, round up
         * example: 2.5 -> 2
         * 3.5 -> 4
         */

    }
    
}
