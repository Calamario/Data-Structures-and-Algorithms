using System;
using Challenge_FIFO_Animal_Shelter.Classes;

namespace Challenge_FIFO_Animal_Shelter
{
    class Program
    {
        static void Main(string[] args)
        {
            FIFOAnimalShelter();
        }

        static void FIFOAnimalShelter()
        {
            //Makes and fills the Animal Shelter with Animals
            AnimalShelter myShelter = new AnimalShelter(new Animal("cat"));
            myShelter.Enqueue(new Animal("cat"));
            myShelter.Enqueue(new Animal("cat"));
            myShelter.Enqueue(new Animal("cat"));
            myShelter.Enqueue(new Animal("cat"));

            //Prints out on console what the shelter looks like
            Console.WriteLine("This is what the shelter looks like");
            myShelter.Print();
            Console.ReadLine();

            //Takes out the first dog in queue
            Console.WriteLine("There is a person here to adopt a dog");
            Console.WriteLine($"Bye bye {myShelter.Dequeue("dog").Value}");
            Console.ReadLine();

            //Prints out on console what the shelter looks like
            Console.WriteLine("This is what the shelter looks like now");
            myShelter.Print();
            Console.ReadLine();
        }
    }
}
