namespace Enumaration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            direction d= direction.east;
            Console.WriteLine((int)d);
        }

        public enum direction { north=2,south,east,west}
    }
}
