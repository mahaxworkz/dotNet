namespace TwoDimArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] months = { "jan", "feb", "march" };
            int[,] sales = new int[3, 3];
            for(int i = 0; i < sales.GetLength(0); i++)
            {
                Console.WriteLine($"Enter the sales for salesman- {i + 1}");
                for(int j=0;j<sales.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the sales for {months[j]} ");
                    sales[i,j]= int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < sales.GetLength(0); i++)
            {
                int tot = 0;
                Console.Write($"salesman- {i + 1}\t");
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    Console.Write($"{sales[i,j]}\t ");
                    
                    tot += sales[i,j];
                }
                Console.WriteLine(tot);
            }
        }
    }
}
