//Method overloading means multiple methods have same name with different parameters

using System;


class Method_Overloading
{
    static void addMethod(int a, int b)
    {
        Console.WriteLine( a + b);

    }
    static void addMethod(double a, double b)
        {
        Console.WriteLine( a + b);
    }
 
    static void Main()
    {
        addMethod(1, 2);
        addMethod(2.3, 3.0);
        
    }
}