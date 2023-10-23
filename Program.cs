using Acces.Models;

namespace Acces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.SetName("Adil");
            person.SetSurName("Ibadov");
            person.SetAge(20);
            //Console.WriteLine("Name : " + r.Name);
            //Console.WriteLine("Surname : " + r.Surname);
            //Console.WriteLine("Age : " +r.Age);
            Console.WriteLine(person.GetFullInfo());
        }
    }
}