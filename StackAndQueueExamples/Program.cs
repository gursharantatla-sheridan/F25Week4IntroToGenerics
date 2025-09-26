namespace StackAndQueueExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
