﻿namespace StackAndQueueExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack example

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            Console.WriteLine("Total items: " + stack.Count);
            foreach (var i in stack)
                Console.WriteLine(i);

            Console.WriteLine("\n\n");

            //int num = stack[1];

            int num = stack.Pop();
            Console.WriteLine(num);

            Console.WriteLine("Total items: " + stack.Count);
            foreach (var i in stack)
                Console.WriteLine(i);

            Console.WriteLine("\n\n");


            num = stack.Peek();
            Console.WriteLine(num);

            Console.WriteLine("Total items: " + stack.Count);
            foreach (var i in stack)
                Console.WriteLine(i);

            Console.WriteLine("\n\n\n");


            // Queue example

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            //num = queue[1];

            Console.WriteLine("Total items: " + queue.Count);
            foreach (var i in queue)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");

            num = queue.Dequeue();
            Console.WriteLine(num);

            Console.WriteLine("Total items: " + queue.Count);
            foreach (var i in queue)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");


            num = queue.Peek();
            Console.WriteLine(num);

            Console.WriteLine("Total items: " + queue.Count);
            foreach (var i in queue)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");
        }
    }
}
