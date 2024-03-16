namespace OopsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
         ITEmployee emp = new ITEmployee();

            emp.SetValue();
            emp.GetValue();


            Console.WriteLine(emp);

             
        }
    }
}
