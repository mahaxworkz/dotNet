namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* var cities = new List<String>();
            cities.Add("bangalore");
            cities.Add("Coimbatore");
            cities.Add("ooty");
            cities.Add("chennai");



            foreach(var name in cities)
            {
                Console.WriteLine(name);
            }*/

            List<Dto> list = new List<Dto>()
            {
                new Dto {author="john",book="faith",price="230"},
                 new Dto {author="ken",book="KnightWarriers",price="450"}
            };
            foreach(Dto dto in list)
            {
                 
                Console.WriteLine($"{dto.book} is written by {dto.author},price is {dto.price}");


            }

             

        }
    }
}
