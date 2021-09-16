using System;

namespace AndExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks:
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punktoi;
            //miinimum bioloogias 95 punkti;
            //programm küsib kasutajal sisestada tema 
            //eksami punktid ja otsustada, kas kasutaja
            // saab arstiks õppida

            Console.WriteLine("Mitu punkti sa matas said.");
            int Mate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mitu pukti sa keemias said.");
            int keemia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mitu punkti sa bioloogias said.");
            int Bioloogia = Convert.ToInt32(Console.ReadLine());

            if (Mate >= 95 && keemia >= 90 && Bioloogia >= 95)
            {
                Console.WriteLine("Võid õppida arstiks");
            }
            else
            {
                Console.WriteLine("Oled liiga rumal, et arstiks õppida");
            }
        }
    }
}
