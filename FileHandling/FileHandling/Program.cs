using System.IO;
namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream(@"C:\Users\Maha\Desktop\dot\Books.txt", FileMode.OpenOrCreate);
            StreamWriter w=new StreamWriter(f);
            String ans = "y";
            while (ans == "y")
            {
                Console.Write("Enter book ID:");
                String id = Console.ReadLine();
                Console.Write("Enter book title :");
                String title = Console.ReadLine();
                Console.Write("Enter book author:");
                String author= Console.ReadLine();

                String line = $"{id},{title},{author}";
                w.WriteLine(line);
                Console.Write("Do you want to add more y/n");
                ans = Console.ReadLine();


            }
            w.Close();
            f.Close();
            Console.WriteLine("thanks for saving");

            FileStream b = new FileStream(@"C:\Users\Maha\Desktop\dot\Books.txt", FileMode.Open);
            StreamReader r = new StreamReader(b);
            String line1 = r.ReadLine();
            while(line1 != null)
            {
                String[] cols = line1.Split(',');
                Console.WriteLine("ID : " + cols[0]);
                Console.WriteLine("Name : " + cols[1]);
                Console.WriteLine("Author : " + cols[2]);

                line1 = r.ReadLine();
            }
            r.Close();
            b.Close();


        }
    }
}