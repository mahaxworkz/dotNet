namespace Aggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address add = new Address(34, "barathiNagar", "cbe", "560345", "india");
            Student stu= new Student(20,"varma","varun",14,8667246802,add);
            stu.display();

             
            

        }
    }
}
