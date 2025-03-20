using System;

class UserInput {
static void Main()
    {
        Console.WriteLine("Enter Your Namme");
        string username = Console.ReadLine();
        Console.WriteLine("Your name is" + " " +username );

        Console.WriteLine("Enter your roll number");
       /*  
          // int roll = Console.ReadLine();
        this will give you error as readline only returns a string
         we use type casting for this 
       */

        int roll = Convert.ToInt32( Console.ReadLine() );

        Console.WriteLine("YOur roll number is : " + roll);
    }
}
