/*Create a List for StudentName and perform following operations:
a. Add() - To Add new student in list
b. Remove() - To Remove Student with specified index
c. RemoveRange() - To Remove student with specified range.
d. Clear() - To clear all the student from the list*/

using System;
using System.Collections;
using System.Collections.Generic;
class L6P2
{
    public static void Main()
    {
        ArrayList studentNames = new ArrayList();

        // 1. Add()
        studentNames.Add("John");
        studentNames.Add("Alice");
        studentNames.Add("Bob");
        studentNames.Add("Emily");
        Console.WriteLine("Student Names:");
        PrintList(studentNames);

        Console.WriteLine("\n---------------------------------------------------------------------\n\n");

        // 2. Remove()
        int indexToRemove = 2;
        studentNames.RemoveAt(indexToRemove);
        Console.WriteLine("Student Names after removing student at index{0} ", indexToRemove);
        PrintList(studentNames);

        Console.WriteLine("\n---------------------------------------------------------------------\n\n");

        // 3. RemoveRange()
        int rangeStartIndex = 0;
        int rangeCount = 2;
        studentNames.RemoveRange(rangeStartIndex, rangeCount);
        Console.WriteLine("Student Names after removing range ");
        PrintList(studentNames);

        Console.WriteLine("\n---------------------------------------------------------------------\n");

        // 4. Clear()
        studentNames.Clear();
        Console.WriteLine("Student Names after clearing the list:");
        PrintList(studentNames);

        Console.WriteLine("---------------------------------------------------------------------\n\n");
    }
    static void PrintList(ArrayList list)
    {
        if (list.Count > 0)
            foreach (object item in list)
            {
                Console.WriteLine(item);
            }
        else
            Console.WriteLine("No elements found...");
    }
}
