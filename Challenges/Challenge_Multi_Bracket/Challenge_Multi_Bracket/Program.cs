using System;
using Challenge_Multi_Bracket.Classes;

namespace Challenge_Multi_Bracket
{
    public class Program
    {
        static void Main(string[] args)
        {
            MultiBracketValidation("()[[]");
            
        }

        public static void MultiBracketValidation(string input)
        {
            Queue queue = MakeBracketQueue(input);
            queue.Print();
            Console.ReadLine();
            if (ValidateBracketEquality(queue))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Makes the string into an array of char and each element becomes
        /// a value for a node only if they are some sort of brackets and
        /// the node is enqueued in the queue.
        /// </summary>
        /// <param name="input">a string</param>
        /// <returns> a queue with nodes that have values of brackets</returns>
        public static Queue MakeBracketQueue(string input)
        {
            //initialized with a node but is dequeued before returning
            Queue queue = new Queue(new Node('f'));
            char[] myChar = input.ToCharArray();
            string myBrackets = "(){}[]";
            char[] bracketArr = myBrackets.ToCharArray();
            //nested foreach to filter out non brackets
            foreach (char item in myChar)
            {
                foreach (char bracket in bracketArr)
                {
                    if (item == bracket)
                    {
                        queue.Enqueue(new Node(item));
                    }
                }
            }
            //dequeuing the initialized f node
            queue.Dequeue();
            return queue;
        }

        /// <summary>
        /// Checks if there is a closing bracket for each opening bracket
        /// it will return true if there is, if not false
        /// </summary>
        /// <param name="queue"> a queue of nodes with only values of brackets</param>
        /// <returns> a bool </returns>
        public static bool ValidateBracketEquality(Queue queue)
        {
            //do this until queue is empty
            while (queue.Front != null)
            {
                if (queue.Front == queue.Rear)
                {
                    return false;
                }
                char checkFor = queue.Dequeue().Value;
                char checkAgainst;
                switch (checkFor)
                {
                    case '(':
                        checkAgainst = ')';
                        break;
                    case '{':
                        checkAgainst = '}';
                        break;
                    case '[':
                        checkAgainst = ']';
                        break;
                    default:
                        return false;
                }
                Node EndNode = queue.Rear;
                //Continue until looked at the whole queue or found the node you were looking for
                while (queue.Front.Value != checkAgainst && queue.Front != EndNode)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                //run once more for the last node
                if (queue.Front.Value == checkAgainst)
                {
                    queue.Dequeue();
                    //return the original state of the queue without the recently founded pairs of brackets
                    if (EndNode.Next != null)
                    {
                        while(queue.Rear != EndNode)
                        {
                            queue.Enqueue(queue.Dequeue());
                        }
                    }
                }
                //couldnt find the node that had the partner bracket
                else
                {
                    return false;
                }
            }
            return true;
        }



        //Doing it with stacks worked on it with Nate

        //public static bool MultiBracketValidation(string input)
        //{
        //    string validChars = "(){}[]";
        //    Stack myStack = new Stack();

        //    foreach (char c in input)
        //    {
        //        if (myStack.Top == null)
        //        {
        //            myStack.Push(new Node(c));
        //        }

        //        else if (CompareBracket(myStack.Top.Value, c))
        //        {
        //            myStack.Pop();
        //        }

        //        else if (validChars.Contains(c))
        //        {
        //            myStack.Push(new Node(c));
        //        }
        //    }
        //    return (myStack.Top == null) ? true : false;
        //}


        //public static bool CompareBracket(char first, char second)
        //{
        //    char equiv;

        //    switch (first)
        //    {
        //        case '{':
        //            equiv = '}';
        //            break;
        //        case '(':
        //            equiv = ')';
        //            break;
        //        case '[':
        //            equiv = ']';
        //            break;
        //        default:
        //            return false;
        //    }
        //    return (second == equiv) ? true : false;
        //}
    }
}
