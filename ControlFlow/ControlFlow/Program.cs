namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name : ");
            String  name= Console.ReadLine();
           
            char letter = 'z';
             for(int i = 0; i < name.Length; i++)
            {
                int count = 0;
                for(int j=i; j < name.Length; j++)
                {
                    if (name[i].Equals(name[j]) )
                    {
                        
                        count++;
                        
                    }
                    
                }
                Console.WriteLine( "count of "+name[i]+" : "+count);
            }
        }
    }
}
