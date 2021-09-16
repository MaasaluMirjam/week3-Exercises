using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja parool
            //programm kontrollib sisestatud andmeid
            //kui sisestatud kasutajatunnus on "admin" ja
            //sisestatud parool on "admin1234"
            //siis programm kuvab "Tere tulemast"
            //muul juhul programm kuvab "Vale kasutajatunnus või parool.Proovi uuesti";

            Console.WriteLine("Palun sisesta kasutajtunnus");
            string username = Console.ReadLine();
            Console.WriteLine("Palun sisesta parool");
            string password = Console.ReadLine();

            /*if (username == "admin" && password == "admin1234") 
            {
                Console.WriteLine("Tere tulemast");
            }
            else 
            {
                Console.WriteLine("Vale kasutajatunnus või parool.Proovi uuesti");
            }
            */
            if (username != "admin" || password != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti");
            }
            else
            {
                Console.WriteLine("Tere tulemast");
            }
        }
    }
}
