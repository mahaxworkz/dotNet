namespace SwitchCaseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String degree;
            Console.WriteLine("Enter your degree : ");
            degree = Console.ReadLine();
           switch(degree)
            {
                case "BE":
                    Console.WriteLine("4 years course");
                    break;

                case "BSc":
                    Console.WriteLine("3 years course");
                    break;
                case "MBBS":
                    Console.WriteLine("5 years course ");
                    break;
                default: 
                    Console.WriteLine("you need to learn more");
                    break;
            }
        }
    }
}
