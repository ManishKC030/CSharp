using System;

class If_Else {

    static void Main()
    {
        // if , else, and else if is same as in C

        //  short hand if..else(ternary operator)
        // synatx: variablle = (condition) ? experssionTrue : experssionFalse

        var x = 7;
        var y = 9;
        if (x < y)
        {
            Console.WriteLine($" y ({y}) is greater than x ({x})");
        }
        else
        {
            Console.WriteLine($" x ({x}) is greater than y ({y})");

        }

        //we can use short hand if..else in this way
        string result = (x < y) ? "Y greater" : "X greater";
        Console.WriteLine(result);
        
    }
}


