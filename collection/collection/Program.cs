using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    //Hashset Implementation
    //Hashset is a data structure defined using Generics contains values that are unique.
    //It Contains the values in uniform datatype and all the elements are unique.
    //Hashset does not store duplicate values.
    //Hashset performs certain functions :
    //1. Add(): This function appends value into the hashset.
    //2. Remove(): This function removes a value from the hashset.
    //3. UnionWith(): This function merges 2 hashsets and updates the merge values into one existing hashset.
    //4. IntersectWith(): This function returns the values which are common in two hashsets and stores those values into one
    //                    existing hashset.
    //5. ExceptWith(): This function returns values which are not in common between two hasets and stores the value into the
    //                 existing hashset.
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> ints = new HashSet<int>();
            HashSet<int> ints1 = new HashSet<int>();
            HashSet<int> ints2 = new HashSet<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(1);
            ints.Add(2);
            ints.Add(4);
            ints1.Add(5);
            ints1.Add(6);
            ints1.Add(10);
            ints1.Add(100);
            ints2.Add(5);
            ints2.Add(6);
            ints2.Add(10);
            ints2.Add(100);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (int i in ints1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (int i in ints2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            ints.Remove(3);
            HashSet<int> myhash2 = new HashSet<int>() {10,100,1000,10000,100000};
            foreach (int i in myhash2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            ints.UnionWith(myhash2);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            ints1.IntersectWith(myhash2);
            foreach (int i in ints1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            ints2.ExceptWith(myhash2);
            foreach (int i in ints2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
