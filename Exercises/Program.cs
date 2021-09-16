using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, kasutajalt sisestada PIN-koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234
            //programm kuvab konsoolis "Tere tulemast."
            //kui sisestatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN. Proovi uuesti."

            Console.WriteLine("Palun sisesta PIN-kood");
            int PIN = Convert.ToInt32(Console.ReadLine());

            /*if (PIN == 1234)
            {
                Console.WriteLine("Tere tulemast.");
            }
            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti.");
            }
            */
            if (PIN != 1234)
            {
                Console.WriteLine("Tere tulemast.");
            }
            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti.");
            }
    }
}
