using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    //list implementation.
    //List is a dynamic array which increases its capacity.
    //List has a capacity of 4 bytes at the intialization and increases 2 times.
    //List is a generic data structure which stores the values of the same datatype.
    //Some basic commands performed on list are :
    //1. Add(): This function helps to add an element in to the list.
    //2. Remove(): This function removes a element present between the brackets from the list.
    //3. RemoveAt(): This function removes an element at the particular index from the list.
    //4. Clear(): This function clears all the elements present in the list.
    //5. IndexOf(): this function specifies the index of an element.
    //foreach loop is used to access the elements from the list.
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Remove(2);
            list.RemoveAt(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list.IndexOf(2));
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            list.Clear();
            Console.WriteLine(list);
        }
    }
}
