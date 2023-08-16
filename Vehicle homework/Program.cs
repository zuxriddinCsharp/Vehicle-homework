namespace Vehicle_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tesla tesla = new Tesla(2023, 40_000, 2, 71.7);

            Wolkswagen wolkswagen = new Wolkswagen(2022, 35_000, 4, 60);

            Toyota toyota = new Toyota(2021, 30_000, 4, 300);

            BMW bmw = new BMW(2020, 25_000, 4, 280);

            Motorcycle motorcycle = new Motorcycle(2019, 10_000, false);

            Airplane airplane = new Airplane(2019, 1_000_000, 5000, true);

            Helicopter helicopter = new Helicopter(2000, 500_000, 300, false, 8);


            Console.WriteLine("Information about Tesla: ");
            tesla.DisplayInfo();
            tesla.ChargeBattarey();

            Console.WriteLine();

            Console.WriteLine("Information about Wolkswagen: ");
            wolkswagen.DisplayInfo();
            wolkswagen.ChargeBattarey();

            Console.WriteLine();

            Console.WriteLine("Information about Toyota: ");
            toyota.DisplayInfo();
            toyota.StartEngine();

            Console.WriteLine();

            Console.WriteLine("Information about BMW: ");
            bmw.DisplayInfo();
            bmw.StartEngine();

            Console.WriteLine();

            Console.WriteLine("Motorcycle information");
            motorcycle.DisplayInfo();

            Console.WriteLine();

            Console.WriteLine("Airplane information");
            airplane.DisplayInfo();

            Console.WriteLine();

            Console.WriteLine("Helicopter information");
            helicopter.DisplayInfo();
        }
    }
}