using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    internal class Program
    {
        //LinkedList Implementation
        //LinkedList is a datastructure which stores the data contiguously.
        //LinkedList is defined in Generics and not defined in Non-Generics.
        //Linkedlist stores values uniformly rather than hetrogenously.
        //LinkedList performs certain functions:
        //1.  AddFirst(): This function adds new node at the head of linkedlist.
        //2.  AddLast(): This function adds new node at the tail of the Linkedlist.
        //3.  Count: This function returns the total number of elements present in LinkedList.
        //4.  First: This function returns the reference to the First Node i.e, the head of the linkedList.
        //5.  Last: This function returns the reference to the Last Node i.e, the tail of the LinkedList.
        //6.  AddBefore(): This function adds a new node before any specified node in the LinkedList.
        //7.  AddAfter(): This function adds a new node after any specified node in the LinkedList.
        //9.  RemoveFirst(): This function removes the first node i.e, the head of the LinkedList.
        //8.  Remove(): This function removes a specific node from the LinkedList.
        //10. RemoveFirst(): This function removes the head node from the LinkedList.
        //11. RemoveLast(): This function removes the tail node from the LinkedList.
        //12. Contains(): This function returns a bool value, if the specified value is present in the LinkedList then it
        //                returns True otherwise False is returned.
        //13. Clear(): This fucntion clears the LinkedList.
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");
            Console.WriteLine(list.Count);
            Console.WriteLine(list.First);
            Console.WriteLine(list.Last);
            list.Remove("c");
            foreach (string s in list) 
                Console.WriteLine(s);
            Console.WriteLine();
            var newnode = list.AddLast("f");
            list.AddBefore(newnode,"g");
            list.AddAfter(newnode,"h");
            foreach (string s in list) 
                Console.WriteLine(s);
            Console.WriteLine();
            list.RemoveFirst();
            list.RemoveLast();
            foreach (string s in list)
                Console.WriteLine(s);
            Console.WriteLine();
            Console.WriteLine(list.Contains("f"));
            list.Clear();
        }
    }
}
