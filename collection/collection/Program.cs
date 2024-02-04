using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    //Queue Implementation.
    //Queue is a data structure which follows First in First Out.
    //Queue can be initialized through generics and non-generics.
    //Generic Queue stores a uniform datatype and Non-Generic Queue stores multiple datatypes.
    //Basic functions implamented in queues:
    //1. Enqueue(): This function adds element into the queue.
    //2. Dequeue(): This function removes the first element from the queue.
    //3. Contains(): This function checks whether the element is present in the queue.
    //4. Count()/Count: This function returns the total number of elements present in the queue.
    //5. Clear(): This function Clears the queue.
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            Queue queue1 = new Queue();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            queue.Dequeue();
            Console.WriteLine(queue.Contains("a"));
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Count());
            queue1.Enqueue(1);
            queue1.Enqueue('a');
            queue1.Enqueue(5.6);
            queue1.Enqueue("you");
            foreach (var item in queue1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            queue.Dequeue();
            Console.WriteLine(queue1.Contains("a"));
            Console.WriteLine(queue1.Peek());
            Console.WriteLine(queue1.Count);
        }
    }
}
