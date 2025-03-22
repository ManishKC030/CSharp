// It is a key concept of oop that allows one class to inherit properties of another class

using System;

class Vehicle // parent class
{
    public string brand;
    public void honk()
    {
        Console.WriteLine("Tuut, Tuut!");
    }
}

class Car : Vehicle //child class, extends Vehicle
{
    public string name;

}

class Inheritance
{
    static void Main()
    {
        Car mycar = new Car();
        mycar.brand = "Ford";
        mycar.name = "Mustang";
        Console.WriteLine(mycar.name + " " + mycar.brand );
        mycar.honk();
    }
}