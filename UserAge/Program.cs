using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaasta;
            //programm kuvab kasutaja sünniaasta konsoolis;

            Console.WriteLine("Palun sisesta oma vanus.");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2021 - userAge;

            //Console.WriteLine("Oled sündinud " + yearOfBirth + ". aastal.");

            Console.WriteLine($"Oled sündinud {yearOfBirth}. aastal.");



        }
    }
}
