using System;

class Person
{
    private string name;  // private field (hidden from outside)

    // public method to set name
    public void SetName(string newName)
    {
        name = newName;
    }

    // public method to get name
    public string GetName()
    {
        return name;
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.SetName("Manish");              // setting value safely
        Console.WriteLine(p.GetName());   // getting value safely
    }
}
