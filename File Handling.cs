// we use System.IO namespace, which allows us to work with files
// File class has many useful methods

using System;
using System.IO;


class File_Handling
{
    static void Main()
    {
        string text = "Hello World!";
        File.WriteAllText("filename.txt", text); //creates and writes contents of text

        string readText = File.ReadAllText("filename.txt");
        Console.WriteLine(readText);
    }
}