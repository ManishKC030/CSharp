//Access modifier is used to set the access level for classes, methods, properties.

using System;

//public is accessible anywhere in the program
class Public
{
    public string message = "I am public modifier and i am accessible from anywhere ";
}

//private is accessible within the same class

class Private
{
    private string secret = "I am private, only class Private can see me";
    
    public Private() {
        Console.WriteLine(secret);
    }
}
 class Access_Modifier
{
    static void Main()
    {
        Public myobj = new Public();
        Console.WriteLine(myobj.message);

        /* 
         * Private myobj2 = new Private();
         * Console.WriteLine(myobj2.secret);  //gives an error due to its protection level
       */

        Private newObj = new Private(); // Now accessible due to constructor
    }
}