// A method is block of code which runs only when it is called
// When you pass data into a method it is known as parameter
// In c# there is main method in all the programs, without which program wont' run
// 

using System;

class Methods
{
    static void MyMethod()
    {
        Console.WriteLine("I am being executed from MyMethod");
    }

    static void MyMethod2()
    {
        Console.WriteLine("Hello, I am being executed from method2");
    }

    static void Parameter(int x, int y)
    {
        Console.WriteLine(x + y);
    }
    

    
    static void Main()
    {
        MyMethod(); //Here i am calling my methods
        MyMethod2();
        int a = 10;
        int b = 20;
        Parameter(a, b);    
    }
}