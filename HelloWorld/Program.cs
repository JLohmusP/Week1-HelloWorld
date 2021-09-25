using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervist!");
            Console.WriteLine("Mis on sinu nimi?");

            string UserName;
            UserName = Console.ReadLine();

            Console.WriteLine("Tere, " + UserName);

            Console.Read();
        }
    }
}
