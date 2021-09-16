using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sünniaastat
            //programm arvutab kasutaja vanust
            //programm kontrollib, kas kasutaja on vanem kui 13 vüi 13 aastat vana
            //kui kasutaja on 13 aastat vana või vanem,
            //siis ta võib Instagarmi kasutada
            //kui kasutaja on noorem, kui 13, siis on ta liiga noor.

            Console.WriteLine("Mis aastal sa oled sündinud");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            if (Age >= 13)
            {
                Console.WriteLine("Võid kasutada Instagrami");
            }
            else
            {
                Console.WriteLine("Oled liiga noor");
            }
        }
    }
}
