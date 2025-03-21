//class serves as a blueprint or template for creating an object
//object is an instance of class which repersents real world entity
//example: car is a class then nissan, toyota, honda are the object 


using System;


class Car
{
    public string color = "red";
    public string model = "Toyota";

}

class oops {

    static void Main()
    {
       Car myobj = new Car();
        Console.WriteLine(myobj.color);
        Console.WriteLine("Your car model is" + myobj.model);
    }


}
