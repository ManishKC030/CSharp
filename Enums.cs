// enums is a special types that represents a group of constants

using System;

class Enums
{
    enum Level 
    {
    High, Medium, Low
    }

    static void Main()
    {
        Level myVar = Level.High;
        Console.WriteLine(myVar);
    }
}