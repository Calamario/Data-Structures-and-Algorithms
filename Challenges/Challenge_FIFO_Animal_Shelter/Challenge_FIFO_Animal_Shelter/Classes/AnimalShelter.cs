using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_FIFO_Animal_Shelter.Classes
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        //AnimalShelter constructor
        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
        }

        /// <summary>
        /// Adds a animal to the rear of the queue
        /// </summary>
        /// <param name="animal"> The animal that is being added </param>
        public void Enqueue(Animal animal)
        {
            Rear.Next = animal;
            Rear = animal;
        }

        /// <summary>
        /// Dequeue the first Animal object that matches the inputted string
        /// If there is no match or any string besides cat or dog, returns the first Animal in Shelter
        /// </summary>
        /// <param name="pref"> a string </param>
        /// <returns> an Animal at Front or the first animal that matches the pref string </returns>
        public Animal Dequeue(string pref)
         {
            Animal Current = Front;
            //Checks if the string is dog or cat
            if (pref == "dog" || pref == "cat")
            {
                //Checks the if the first animal is what the user wants
                if (pref == Front.Value)
                {
                    Front = Front.Next;
                    Current.Next = null;
                    return Current;
                }
                while (Current.Next != null && Current.Next.Value != pref)
                {
                    Current = Current.Next;
                }
                //If the animal user wants isnt in the shelter returns the front animal
                if (Current.Next == null)
                {
                    Current = Front;
                    Front = Front.Next;
                    Current.Next = null;
                    return Current;
                }
                //When user pref is found, returns that animal and removes it from the queue
                Animal Temp = Current.Next;
                Current.Next = Temp.Next;
                Temp.Next = null;
                return Temp;
            }
            //If they enter anything else return the front animal
            else
            {
                Front = Front.Next;
                Current.Next = null;
                return Current;
            }
        }

        /// <summary>
        /// Simple method to print out what the queue looks like to teh console
        /// </summary>
        public void Print()
        {
            Animal Current = Front;
            Console.Write("Front ");
            while (Current.Next != null)
            {
                Console.Write(Current.Value);
                Console.Write(" > ");
                Current = Current.Next;
            }
            Console.Write(Current.Value);
            Console.WriteLine(" Rear");
        }
    }
}
