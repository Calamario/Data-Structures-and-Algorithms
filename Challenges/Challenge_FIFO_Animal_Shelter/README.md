# Stacks and Queue - FIFO Animal Shelter
To further our knowledge on data structures and algorithms, we will be manipulating Queues.

## Challenge
Create a class called Animal Shelter that is a queue of Animals.
The Animals are a class with a string value and a Animal Next as its properties.
Make sure the Animal Shelter has two methods, Enqueue that takes in an Animal 
and adds it to the rear of teh Animal Shelter, and Dequeue which takes in a string
and returns the first Animal with the value that is the same as the inputted string.


## Solution

![merged](../../assets/FIFO_animal_shelter_visual.jpg)

## Code
The code implemented slightly differs from the Psuedo code in our solution.
The Dequeue is refactoredto check for any valid inputs. The Psuedo
code fails to remove the animals from the Animal Shelter for when the 
requested animal was not in the Shelter and user asked for animnals besides
cat and dog. This has been addressed in the code.
