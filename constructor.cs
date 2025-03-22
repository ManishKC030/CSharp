//constructor is special method that is automtically called when object of class is created

using System;
class Car
{
    public string brand;
    public string model;
    
    //creating a constructor for Car class
    public Car()
    {
        brand = "Honda";
        model = "Civic";
    }
}

class constructor {

   static void Main()
    {
        Car objcar = new Car(); 
        Console.WriteLine(objcar.brand);
        Console.WriteLine(objcar.model);
    }
}
