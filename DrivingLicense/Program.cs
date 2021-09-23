using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm karvutab kasutaja vanuse
            //kui kasutaja on on noorem kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et juhilubasid saada."
            //kui kasutaja on vanem kui 18, siis programm kuvab konsoolis
            //"Oled piisavalt vana, et juhilubasid saada."
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne, oled täpselt nii vana, et juhilubasid taotleda!"

            Console.WriteLine("Palun sisesta oma sünniaasta.");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - birthYear;

            if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilubasid saada.");
                Console.WriteLine("Turvalist sõitu!");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilubasid saada.");
            }
            else
            {
                Console.WriteLine("Palju õnne, oled täpselt nii vana, et juhilubasid taotleda!");
                Console.WriteLine("Turvalist sõitu!");
            }

           
        }
    }
}
