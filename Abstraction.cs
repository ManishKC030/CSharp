// Abstraction is process of hiding certain details and showing only essentila information to user

using System;

abstract class Animal
{
    public abstract void MakeSound(); //abstract method

}

class Dog : Animal //inheriting dog from animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says Woof Woof");
    }
}
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat says Meow Meow");

    }

    class Abstraction
    {
        static void Main()
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();
            myCat.MakeSound();
            myDog.MakeSound();
        }
    }
}