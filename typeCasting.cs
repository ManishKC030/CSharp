using System;

class typeCasting { 

    //type casting means  converting one data type into another
    /*  
     there are 2 types of type casting in c#
        . implicit casting(automatically) -> converting smaller type to larger
        . explicit casting(manually) ->  converting larger type to samller
            
     */
    static void Main()
    {
        int myInt = 10;
        float myFloat = myInt; //automatic conversion

        Console.WriteLine(myFloat);
       
    
          double myDouble = 9.28; 
           int myInt2 = (int)myDouble;
        Console.WriteLine(myInt2);
       
        //we can laso use (Convert.To....)
        Console.WriteLine(Convert.ToInt32(myDouble));

    }
} 
