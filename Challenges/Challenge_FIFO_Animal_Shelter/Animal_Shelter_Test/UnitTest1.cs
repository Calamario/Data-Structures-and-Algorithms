using System;
using Xunit;
using Challenge_FIFO_Animal_Shelter.Classes;

namespace Animal_Shelter_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("dog", "dog")]
        [InlineData("cat", "cat")]
        public void CanEnqueue(string value, string expected)
        {
            AnimalShelter myShelter = new AnimalShelter(new Animal("cat"));
            myShelter.Enqueue(new Animal(value));

            Assert.Equal(expected, myShelter.Rear.Value);
        }

        [Theory]
        [InlineData("dog", "dog")]
        [InlineData("cat", "cat")]
        public void CanReturnCorrectAnimalDequeue(string value, string expected)
        {
            AnimalShelter myShelter = new AnimalShelter(new Animal("cat"));
            myShelter.Enqueue(new Animal("cat"));
            myShelter.Enqueue(new Animal("dog"));
            myShelter.Enqueue(new Animal("cat"));

            Assert.Equal(expected, myShelter.Dequeue(value).Value);
        }

        [Theory]
        [InlineData("cat", "dog")]
        [InlineData("dog", "cat")]
        public void CanDequeueAnimalInCorrectPositionFront(string value, string expected)
        {
            AnimalShelter myShelter = new AnimalShelter(new Animal("cat"));
            myShelter.Enqueue(new Animal("dog"));
            myShelter.Enqueue(new Animal("cat"));
            myShelter.Enqueue(new Animal("dog"));

            myShelter.Dequeue(value);

            Assert.Equal(expected, myShelter.Front.Value);
        }

        [Theory]
        [InlineData("cat", "dog")]
        [InlineData("dog", "dog")]
        public void CanDequeueAnimalInCorrectPositionRear(string value, string expected)
        {
            AnimalShelter myShelter = new AnimalShelter(new Animal("cat"));
            myShelter.Enqueue(new Animal("dog"));
            myShelter.Enqueue(new Animal("cat"));
            myShelter.Enqueue(new Animal("dog"));

            myShelter.Dequeue(value);

            Assert.Equal(expected, myShelter.Rear.Value);
        }

        [Fact]
        public void CanReturnCatWhenNoDog()
        {
            AnimalShelter myShelter = new AnimalShelter(new Animal("cat"));
            myShelter.Enqueue(new Animal("cat"));
            myShelter.Enqueue(new Animal("cat"));
            myShelter.Enqueue(new Animal("cat"));

            myShelter.Dequeue("dog");

            Assert.Equal("cat", myShelter.Dequeue("dog").Value);
        }
    }
}
