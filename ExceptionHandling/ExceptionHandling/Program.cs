namespace ExceptionHandling
{
     
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.Write("Enter your name : ");
            name = Console.ReadLine();
            try
            {
                CheckError(name);
            }
            catch(Exception e)
            {
                Console.WriteLine(String.Concat(e.StackTrace, e.Message));
            }
             
           
            
        }
        public static void  CheckError(String name)
        {
            if (name.Length < 3)
            {
                throw new Exception01("name must have more than 3 charachters");
            }
            else
            {
                Console.WriteLine(name);
            }

        }
    }
}
