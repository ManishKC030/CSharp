using System;

class Variables


{
    static void Main()
    {
        //variables are the container or storage location that hold data or a value

        int myNum = 20;
        myNum = 30; // this changes myNum to 30
        Console.WriteLine(myNum);

        char myChar = 'A';
        Console.WriteLine(myChar);

        string myStr = "Hello There";
        Console.WriteLine(myStr);

        //Reteiving from Contsants Class 
        // you can have multiple class in same file but only one class should contain Main method
        Console.WriteLine(Constants.myCons);
    }
}

class Constants
{
    //unlike variables constant value cant be changed

    public const int myCons = 40;
    myCons = 10;


}


