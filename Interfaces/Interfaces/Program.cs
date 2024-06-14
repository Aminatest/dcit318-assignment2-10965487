using System;

namespace MovableExample
{
    // Define the interface IMovable
    interface IMovable
    {
        // Method to be implemented in classes that implement this interface
        void Move();
    }

    // Class Car that implements IMovable
    class Car : IMovable
    {
        // Implement the Move method
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class Bicycle that implements IMovable
    class Bicycle : IMovable
    {
        // Implement the Move method
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    // Main class
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            // Call the Move method on each instance
            car.Move();         // Outputs: Car is moving
            bicycle.Move();     // Outputs: Bicycle is moving
        }
    }
}
