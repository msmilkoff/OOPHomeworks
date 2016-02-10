using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PCCatalog
{
    class PCCatalog
    {
        static void Main()
        {
            var pc = new Computer();
            pc.Name = "My PC";

            var ram = new Component("RAM", 150.5m);
            var cpu = new Component("Processor", 259.99m);

            pc.Components = new List<Component>();
            pc.Components.Add(ram);
            pc.Components.Add(cpu);
            pc.Components.Add(new Component("Graphics", 95.66m));

            ram.Details = "8 GB DDR3, KINGSTON";
            cpu.Details = "Intel Core® i5";

            var pc1 = new Computer("Gosho's PC");
            var pc2 = new Computer("Pesho's PC");
            var pc3 = new Computer("Vlado's PC");

            pc1.Components = new List<Component>();
            pc2.Components = new List<Component>();
            pc3.Components = new List<Component>();

            pc1.Components.Add(new Component("RAM", 167.65m, "6 GB DDR3, KINGSTON"));
            pc1.Components.Add(new Component("Graphics", 252m, "512 MB"));
            pc1.Components.Add(new Component("CPU", 199.99m, "AMD Athlon 64 x2, 2.11 GHz"));
            pc1.Components.Add(new Component("HDD", 68m, "Hitachi"));

            pc2.Components.Add(new Component("RAM", 100m, "4 GB DDR3, KINGSTON"));
            pc2.Components.Add(new Component("Graphics", 212.35m, "1GB"));
            pc2.Components.Add(new Component("HDD", 188m, "500 RPM"));

            pc3.Components.Add(new Component("RAM", 129.65m, "4 GB DDR3"));
            pc3.Components.Add(new Component("HDD", 212.35m, "1GB"));
            pc3.Components.Add(new Component("Processor", 250m, "Intel Core 2 Duo, 2.8 GHz"));

            var computers = new List<Computer>();
            computers.Add(pc);
            computers.Add(pc1);
            computers.Add(pc2);
            computers.Add(pc3);

            var sortedComputers = computers
                .OrderBy(x => x.TotalComponentsPrice(x.Components));

            foreach (var computer in sortedComputers)
            {
                computer.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}
