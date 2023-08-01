/*Create a Queue which takes integer values and perform following 
operations: 
a. Enqueue() - Adds an item into the queue.
b. Dequeuer() - Returns an item from the beginning of the queue and 
 removes it from the queue.
c. Peek() - Returns an first item from the queue without removing it.
d. Contains() - Checks whether an item is in the queue or not
e. Clear() - Removes all the items from the queue*/

using System;
using System.Collections.Generic;
class L6P4
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();
        // 1. Enqueue()
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        Console.WriteLine("Queue:");
        PrintQueue(queue);


        // 2. Dequeue()
        int dequeuedItem = queue.Dequeue();
        Console.WriteLine("\nDequeued Item: {0}", dequeuedItem);
        Console.WriteLine("Queue after dequeuing an item:");
        PrintQueue(queue);


        // 3. Peek()
        int peekedItem = queue.Peek();
        Console.WriteLine("\nPeeked Item: {0}", peekedItem);


        // d. Contains() 
        int itemToFind = 30;
        bool containsItem = queue.Contains(itemToFind);
        Console.WriteLine("\nQueue contains {0}?{1}", itemToFind, containsItem);
        itemToFind = 50;
        containsItem = queue.Contains(itemToFind);
        Console.WriteLine("Queue contains {0}? {1}", itemToFind, containsItem);


        // e. Clear()
        queue.Clear();
        Console.WriteLine("\nQueue after clearing all items:");
        PrintQueue(queue);
    }
    static void PrintQueue(Queue<int> queue)
    {
        if (queue.Count > 0)
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        else
            Console.WriteLine("No Element Found ..");
    }
}
