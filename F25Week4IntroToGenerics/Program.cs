namespace F25Week4IntroToGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;

            object o = i;   // boxing

            object o2 = 6;

            i = (int)o;     // unboxing

            //if (AreEqual(5, "hello"))
            if (AreEqual<int>(5, 5))
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");



            int[] intArr = { 3, 4, 5, 6, 4 };
            double[] doubleArr = { 3.3, 5.5, 7.7, 2.2 };
            char[] charArr = { 'h', 'e', 'l', 'l', 'o' };

            PrintArray<int>(intArr);
            PrintArray<double>(doubleArr);
            PrintArray<char>(charArr);
        }

        static void PrintArray<T>(T[] array)
        {
            Console.WriteLine("\nNumber of items: " + array.Length);

            foreach (T i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        // non-generic method
        static bool AreEqual(object v1, object v2)
        {
            return v1.Equals(v2);
        }

        // generic method
        static bool AreEqual<T>(T v1, T v2)
        {
            return v1.Equals(v2);
        }
    }
}
