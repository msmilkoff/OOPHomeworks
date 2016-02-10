using System;

namespace _02.LaptopShop
{
    class LaptopShop
    {
        static void Main()
        {
            Laptop toshiba = new Laptop("Toshiba R2D2", 1000);
            Console.WriteLine(toshiba);
            Console.WriteLine();

            toshiba.Ram = "4 GB DDR3";
            toshiba.Battery = new Battery("Li-ion 2009", 4.5);

            Console.WriteLine(toshiba.Battery);
            Console.WriteLine();
            Console.WriteLine(toshiba);

            toshiba.Manufacturer = "Toshiba";
            toshiba.Processor = "Intel Core i7";
            toshiba.HDD = "1 TB";
            Console.WriteLine();

            Console.WriteLine(toshiba.Manufacturer);
            Console.WriteLine(toshiba.Processor);
            Console.WriteLine(toshiba.HDD);

           //var hp = new Laptop("HP", -6);  //<--- this will throw an Exception
            
        }
    }
}
