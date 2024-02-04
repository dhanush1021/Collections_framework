using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    //Dictionary Implementation
    //Dictionary are used to link between two data types.
    //Dictinary are of two types:
    //1) Dictionary: This contains a set paired values in order of values added to the dictionary
    //2) Sorted Dictionary: This contains the set of paired values same as Dictionary, But the difference from the 
    //                      Dictionary is that the key values are sorted in ascending order.
    //Some basic commands performed in Dictionary:
    //1. Add(): This function adds a pair value in to the dictionary in which the first parameter passed represents the key
    //          value which links with the key's value represented in the second parameter.
    //2. Remove(): This function removes the value along with the key fomr the dictionary.
    //3. ContainsKey(): This function returs a bool value when the dictionary contains a particular key
    //4. ContainsValue(): This function returns a bool value when a value is present in Dictionary.
    //5. Clear(): This function clears all the data present in the dictionary.
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> linked = new Dictionary<int,string>();
            linked.Add(2,"Kill");
            linked.Add(4,"Survive");
            Console.WriteLine(linked.ContainsKey(2));
            Console.WriteLine(linked.ContainsValue("Kill"));
            linked.Add(1,"Play");
            linked.Add(3, "Push");
            foreach (var key in linked.Keys)
            {
                Console.WriteLine($"{key} : {linked[key]}");
            }
            linked.Remove(2);
            Console.WriteLine(linked.Count());
            foreach (var key in linked.Keys)
            {
                Console.WriteLine($"{key} : {linked[key]}");
            }
            linked.Clear();
        }
    }
}
