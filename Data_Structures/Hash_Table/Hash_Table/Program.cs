using Hash_Table.Classes;
using System;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeHashTable();
            Console.ReadLine();
        }

        public static void MakeHashTable()
        {
            HashTable hash = new HashTable();
            hash.Add("one", 1);
            hash.Add("two", 2);
            hash.Add("three", 3);
            hash.Add("four", 4);
            hash.Add("five", 5);
            hash.Add("six", 6);
            hash.Add("seven", 7);
            hash.Add("eight", 8);
            hash.Add("nine", 9);
            hash.Add("ten", 10);
            hash.Add("net", 1000);
            hash.Add("eerht", 1001);
            hash.Add("hreet", 1002);
            hash.Add("ereth", 1003);

            Console.WriteLine($"Does \"three\" exist in this HashTable: {hash.Contains("three")}");
            Console.WriteLine($"It's value is : {hash.Find("three")}");
            Console.WriteLine($"Does \"ten\" exist in this HashTable: {hash.Contains("ten")}");
            Console.WriteLine($"It's value is : {hash.Find("ten")}");
            Console.WriteLine($"Does \"net\" exist in this HashTable: {hash.Contains("net")}");
            Console.WriteLine($"It's value is : {hash.Find("net")}");

            Console.WriteLine($"Does \"eerht\" exist in this HashTable: {hash.Contains("eerht")}");
            Console.WriteLine($"It's value is : {hash.Find("eerht")}");

            Console.WriteLine($"Does \"hreet\" exist in this HashTable: {hash.Contains("hreet")}");
            Console.WriteLine($"It's value is : {hash.Find("hreet")}");

            Console.WriteLine($"Does \"ereth\" exist in this HashTable: {hash.Contains("ereth")}");
            Console.WriteLine($"It's value is : {hash.Find("ereth")}");

            Console.WriteLine($"Does \"eighteen\" exist in this HashTable: {hash.Contains("eighteen")}");
        }
    }
}
