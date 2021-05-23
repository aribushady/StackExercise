using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();
            stack.Push(16);
            stack.Push(10);
            stack.Push(5);
            stack.Push(20);

            for (int i = 0; i <= 5; i++)
            {
               
                stack.Push(i);
            }

            stack.Print();

            Console.WriteLine($"Peeked: {stack.Peek()}");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Popped: {stack.Pop()}");
            }

            Console.WriteLine($"Peeked: {stack.Peek()}");

            stack.Print();
            







        }
    }
}
