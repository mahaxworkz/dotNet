namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computes com = new Computes(Sum);
            Computes com1 = new Computes(Product);
            int result= com(12, 24);
            Console.WriteLine(result);
            int result1 = com1(12, 24);
            Console.WriteLine(result1);
        }

        public delegate int Computes(int a, int b);
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Product(int a, int b)
        {
            return a * b;
        }
    }
}
