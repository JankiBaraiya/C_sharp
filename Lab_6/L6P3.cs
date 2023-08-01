/*Create a Stack which takes integer values and perform following 
operations:
a. Push() - To Add new item in stack
b. Pop() - To Remove item from the stack
c. Peek() – To Return the top item from the stack.
d. Contains() - To Checks whether an item exists in the stack or not.
e. Clear() - To clear items from stack*/

using System;
using System.Collections.Generic;
using System.Collections;
class L6P3
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();


        // 1. Push()
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        Console.WriteLine("Stack:");
        PrintStack(stack);



        // 2. Pop()
        stack.Pop();
        Console.WriteLine("Stack after popping an item:");
        PrintStack(stack);


        // 3. Peek()

        Console.WriteLine("\nTop Item: {0}", stack.Peek());


        // 4. Contains()
        int itemToFind = 30;
        bool containsItem = stack.Contains(itemToFind);
        Console.WriteLine("\nStack contains {0}?{1}", itemToFind, containsItem);
        itemToFind = 50;
        containsItem = stack.Contains(itemToFind);
        Console.WriteLine("Stack contains {0}? {1}", itemToFind, containsItem);


        // 5. Clear()
        stack.Clear();
        Console.WriteLine("\nStack Clear");
    }
    static void PrintStack(Stack stack)
    {
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}

