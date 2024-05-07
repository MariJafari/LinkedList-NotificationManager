using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create the first LinkedList with 10 random integers
        LinkedList<int> originalList = GenerateRandomLinkedList(10);

        // Display the original LinkedList
        Console.WriteLine("Original LinkedList:");
        DisplayLinkedList(originalList);

        // Create a copy of the original LinkedList in reverse order
        LinkedList<int> reversedList = ReverseLinkedList(originalList);

        // Display the reversed LinkedList
        Console.WriteLine("\nReversed LinkedList:");
        DisplayLinkedList(reversedList);
    }

    // Method to generate a LinkedList of random integers
    static LinkedList<int> GenerateRandomLinkedList(int size)
    {
        LinkedList<int> list = new LinkedList<int>();
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            list.AddLast(random.Next(1, 100)); // Generate random integers between 1 and 100
        }

        return list;
    }

    // Method to reverse a LinkedList
    static LinkedList<T> ReverseLinkedList<T>(LinkedList<T> originalList)
    {
        LinkedList<T> reversedList = new LinkedList<T>();

        foreach (var item in originalList)
        {
            reversedList.AddFirst(item);
        }

        return reversedList;
    }

    // Method to display the elements of a LinkedList
    static void DisplayLinkedList<T>(LinkedList<T> list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
