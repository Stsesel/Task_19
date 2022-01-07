using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer() { NameOfProduct = 101, ComputerBrand  = "HP Pavilion Gaming TG01", ProcessorType ="Intel Core i5", CPUFreqency = 2600, RAMsize = 16, HardDiskSpace = 2, VideoCardMemory = 2, ComputerPrice = 70000, Amount = 35},
                new Computer() { NameOfProduct = 102, ComputerBrand  = "HP Pavilion Gaming TV01", ProcessorType ="Intel Core i7", CPUFreqency = 2800, RAMsize = 16, HardDiskSpace = 1, VideoCardMemory = 1, ComputerPrice = 90000, Amount = 15},
                new Computer() { NameOfProduct = 103, ComputerBrand  = "Lenovo Legion R3 28IMB05", ProcessorType ="AMD Zen 2 Matisse 3", CPUFreqency = 2900, RAMsize = 16, HardDiskSpace = 2, VideoCardMemory = 1, ComputerPrice = 120000, Amount = 40},
                new Computer() { NameOfProduct = 104, ComputerBrand  = "Lenovo Legion R5 28IMB25", ProcessorType ="AMD Zen 2 Matisse 3", CPUFreqency = 2900, RAMsize = 32, HardDiskSpace = 4, VideoCardMemory = 2, ComputerPrice = 170000, Amount = 10},
                new Computer() { NameOfProduct = 105, ComputerBrand  = "Lenovo Legion R7 28IMB25", ProcessorType ="AMD Zen 2 Matisse 3", CPUFreqency = 2900, RAMsize = 64, HardDiskSpace = 4, VideoCardMemory = 4, ComputerPrice = 220000, Amount = 20},
                new Computer() { NameOfProduct = 106, ComputerBrand  = "Dell Precision 5820", ProcessorType ="Intel Core i9", CPUFreqency = 2900, RAMsize = 64, HardDiskSpace = 4, VideoCardMemory = 4, ComputerPrice = 410000, Amount = 3},
                new Computer() { NameOfProduct = 107, ComputerBrand  = "Apple Mac mini 2020 M1", ProcessorType ="Apple V1", CPUFreqency = 3200, RAMsize = 8, HardDiskSpace = 1, VideoCardMemory = 1, ComputerPrice = 130000, Amount = 31},
                new Computer() { NameOfProduct = 108, ComputerBrand  = "Acer Aspire TC-895", ProcessorType ="Intel Core i3", CPUFreqency = 3000, RAMsize = 8, HardDiskSpace = 1, VideoCardMemory = 1, ComputerPrice = 130000, Amount = 10},
                new Computer() { NameOfProduct = 109, ComputerBrand  = "Acer Aspire TC-895", ProcessorType ="Intel Core i5", CPUFreqency = 3200, RAMsize = 16, HardDiskSpace = 2, VideoCardMemory = 0.5, ComputerPrice = 150000, Amount = 10},
                new Computer() { NameOfProduct = 110, ComputerBrand  = "Acer Aspire TC-1095", ProcessorType ="Intel Core i7", CPUFreqency = 3200, RAMsize = 32, HardDiskSpace = 4, VideoCardMemory = 2, ComputerPrice = 200000, Amount = 40},
            };

            Console.WriteLine("Введите название процессора");
            string processortype = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.ProcessorType == processortype).ToList();
            Print(computers1);
            Console.WriteLine();

            Console.WriteLine("Введите объем ОЗУ");
            double cpufreqency = Convert.ToDouble(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.CPUFreqency >= cpufreqency).ToList();
            Print(computers2);
            Console.WriteLine();

            Console.WriteLine("Cписок, отсортированный по увеличению стоимости");
            List<Computer> computers3 = computers.OrderBy(x => x.ComputerPrice).ToList();
            Print(computers3);
            Console.WriteLine();

            Console.WriteLine("Cписок, сгруппированный по типу процессора");
            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.ProcessorType);
            foreach (IGrouping<string, Computer> item1 in computers4)
            {
                Console.WriteLine(item1.Key);
                foreach (Computer item in item1)
                {
                    Console.WriteLine($"{item.NameOfProduct} {item.ComputerBrand} { item.ProcessorType} {item.CPUFreqency} {item.RAMsize} {item.HardDiskSpace} {item.VideoCardMemory} {item.ComputerPrice} {item.Amount}");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Cамый дорогой компьютер");
            Computer computers5 = computers.OrderByDescending(x => x.ComputerPrice).FirstOrDefault();
            Console.WriteLine($"{computers5.NameOfProduct} {computers5.ComputerBrand} {computers5.ProcessorType} {computers5.CPUFreqency} {computers5.RAMsize} {computers5.HardDiskSpace} {computers5.VideoCardMemory} {computers5.ComputerPrice} {computers5.Amount}");
            Console.WriteLine();

            Console.WriteLine("Cамый бюджетный компьютер");
            Computer computers6 = computers.OrderByDescending(x => x.ComputerPrice).LastOrDefault();
            Console.WriteLine($"{computers6.NameOfProduct} {computers6.ComputerBrand} {computers6.ProcessorType} {computers6.CPUFreqency} {computers6.RAMsize} {computers6.HardDiskSpace} {computers6.VideoCardMemory} {computers6.ComputerPrice} {computers6.Amount}");
            Console.WriteLine();

            Console.WriteLine("Есть ли хотя бы один компьютер в количестве не менее 30 штук?");
            if (computers.Any(x => x.Amount >= 30))
                Console.WriteLine("Да, есть");
            else 
                Console.WriteLine("Нет, нету");

            Console.ReadKey();

        }

        static void Print(List<Computer> computers)
        {
            foreach (Computer item in computers)
            {
                Console.WriteLine($"{item.NameOfProduct} {item.ComputerBrand} { item.ProcessorType} {item.CPUFreqency} {item.RAMsize} {item.HardDiskSpace} {item.VideoCardMemory} {item.ComputerPrice} {item.Amount}");
            }
            Console.WriteLine();
        }
    }
}
