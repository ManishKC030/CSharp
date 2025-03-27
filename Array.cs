using System;

class Array
{
    static void Main()
    {
        //to declare an array, define variable type with square brackets
        string[] cars = { "honda", "BMW", "Ford", "Mazda" };
        Console.WriteLine(cars[1]); //output BMW


        // Initialization only
        int[] numbers = new int[5];  // Array with 5 elements

        // Declaration 
         numbers = new int[] { 10, 20, 30, 40, 50 };

        //in short we can use just like cars array
        // int[] numbers = {10,20,30,40,50};

        Console.WriteLine(numbers[3]);
    }
}