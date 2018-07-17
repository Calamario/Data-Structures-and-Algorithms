using Challenge_FindRepeated.Classes;
using System;

namespace Challenge_FindRepeated
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "There was once a big dog that ate many apples until it was full but it never really was full";
            string word = RepeatedWord(text);
            Console.WriteLine(text);
            Console.WriteLine($"The repeated word was: {word}");
            Console.ReadLine();
            text = "no";
            Console.WriteLine(text);
            Console.WriteLine($"The repeated word was: {RepeatedWord(text)}");
            Console.ReadLine();
            text = "";
            Console.WriteLine(text);
            Console.WriteLine($"The repeated word was: {RepeatedWord(text)}");
            Console.ReadLine();
        }

        public static string RepeatedWord(string text)
        {
            HashTable hash = new HashTable();
            string[] words = text.Split(" ");
            foreach (string word in words)
            {
                if (hash.Contains(word))
                {
                    return word;
                }
                hash.Add(word, 1);
            }
            return "";
        }
    }
}
