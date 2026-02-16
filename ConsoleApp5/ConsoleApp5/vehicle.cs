using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class vehicle
    {
        public string Color;
        public int Year; // Buraxılış ili
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;
        public Vehicle(int year)
        {
            this.Year = year;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"--- Maşın Məlumatı ---");
            Console.WriteLine($"Marka/Model: {Brand} {Model}");
            Console.WriteLine($"İl: {Year} | Rəng: {Color}");
            Console.WriteLine($"Yanacaq: {CurrentFuel}L / {FuelCapacity}L");

        }
    }
