using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_FIFO_Animal_Shelter.Classes
{
    public class Animal
    {
        public string Value { get; set; }
        public Animal Next { get; set; }

        public Animal(string value)
        {
            Value = value;
        }
    }
}
