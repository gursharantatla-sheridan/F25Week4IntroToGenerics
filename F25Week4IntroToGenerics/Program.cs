namespace F25Week4IntroToGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;

            object o = i;   // boxing

            i = (int)o;     // unboxing

            //if (AreEqual(5, "hello"))
            if (AreEqual<int>(5, 5))
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");
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
