namespace OopsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
         ITEmployee emp = new ITEmployee();
            Properties props = new Properties(id: 1, name: "maha", age: 21);
            Console.WriteLine(props.id);
            Console.WriteLine(props.name);

            emp.SetValue();
            emp.GetValue();


            Console.WriteLine(emp);

             
        }
    }
}
