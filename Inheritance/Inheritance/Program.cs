using System;

namespace AnimalSounds
{
    // Base class
    class Animal
    {
        // Virtual method to be overridden in derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    class Dog : Animal
    {
        // Override the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    class Cat : Animal
    {
        // Override the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    // Main class
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Animal, Dog, and Cat
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call the MakeSound method on each instance
            genericAnimal.MakeSound();  // Outputs: Some generic sound
            dog.MakeSound();            // Outputs: Bark
            cat.MakeSound();            // Outputs: Meow
        }
    }
}
