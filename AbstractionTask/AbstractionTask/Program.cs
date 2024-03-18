namespace AbstractionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Rectangle(4,7);
            int area= s.area();
           Console.WriteLine (s.ToString());
            Console.WriteLine($"Area is {area}");

        }
    }
}
