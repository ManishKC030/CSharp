//interface is the another way to achieve abstraction
//interfaces doesn't conatins access modifiers

using System;

interface IAnimal // "I" indicates its and interface, but its not necessary  
{
    void animalSound();
}

class Dog : IAnimal // Dog implements IAnimal interface
{
    public void animalSound()
    {
        Console.WriteLine("Dog barks: Bow Bow");
    }
}
class Interface 
{
    static void Main()
    {
       Dog myDog = new Dog();
        myDog.animalSound();
    }
}


