using System;

namespace  FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int p,n,r,si;
            Console.Write("Enter  the value of p");
            p=int.Parse(Console.ReadLine());
            Console.Write("Enter  the value of n");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter  the value of r");
            r = int.Parse(Console.ReadLine());
            si = (p * n * r) / 100;
            Console.WriteLine($"value of si is {si}.");



        }
    }
}
