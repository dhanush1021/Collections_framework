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
        //Stack Implementation
        //Stack is a data structure which follows the First in Last out Concept.
        //Stack is defined both in Generic and Non-Generic.
        //Stack perfomrs certain Functions:
        //1. Push(): This function pushes an element into the stack.
        //2. Pop(): This function pops out the element which is present on the top of the stack.
        //3. Contains(): This function return a bool value based on the availability of an elemnt in the stack.
        //4. Peek(): This function returns the top element of the stack.
        //5. Clear(): This function is used to clear the stack.
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Stack stack1 = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack1.Push(1);
            stack1.Push('a');
            stack1.Push(7.56);
            stack1.Push("you");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            foreach (object i in stack1)
            {
                Console.WriteLine(i);
            }
            stack.Pop();
            stack1.Pop();
            Console.WriteLine(stack.Contains(1));
            Console.WriteLine(stack1.Contains("yo"));
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack1.Peek());
            stack.Clear();
            stack1.Clear();
        }
    }
}
