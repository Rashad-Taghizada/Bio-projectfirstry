namespace ConsoleApp5
{
    internal class Program
    {

          public void Drive(double km)
        {
            double lazimOlanYanacaq = km * FuelFor1Km;

            if (CurrentFuel >= lazimOlanYanacaq)

            { 
                CurrentFuel = CurrentFuel - lazimOlanYanacaq;
                Console.WriteLine($"{km} km gedildi. Qalan benzin: {CurrentFuel} litr.");
            }
            else
            {
                // Benzin yetmiyorsa uyarı ver
                Console.WriteLine("Bu məsafəni getmək üçün kifayət qədər benzin yoxdur!");
            }
        }
    }

}

