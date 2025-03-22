// Polymorphism means "many forms"

using System;

class Animal
{
 public virtual void animalSound() //virtual allows parent class method to overriden
    {
        Console.WriteLine("Animal Makes a Sound");
     }
}

class Dog:Animal
{
    public override void animalSound() //without overriding base class is only accessed
    {
        Console.WriteLine("Dogs barks: Bow Bow");
    }
}

class Cat:Animal
{
    public override void animalSound()
    {
        Console.WriteLine("Cats Meow : Meow Meow");
    }
}

class Polymorphism
{
    static void Main()
    {
        Animal myanimal = new Animal();
        Animal mydog = new Dog();
        Animal mycat = new Cat();
         myanimal.animalSound();
        mydog.animalSound();
        mycat.animalSound();
    }
}