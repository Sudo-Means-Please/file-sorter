using System;
using System.Threading;

namespace Sorter
{
    class Program
    {
        Sorting Sorting = new Sorting();
        static void Main(string[] args)
        {
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║       Enter Folder to sort:       ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
            Console.Write("   >");
            string rootPath = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║      Select Option to sort by     ║");
            Console.WriteLine("╠═══════════════════════════════════╣");
            Console.WriteLine("║      [1]Filetype                  ║");
            Console.WriteLine("╠═══════════════════════════════════╣");
            Console.WriteLine("║      [2]AccessDate                ║");
            Console.WriteLine("╠═══════════════════════════════════╣");
            Console.WriteLine("║      [3]ModifiedDate              ║");
            Console.WriteLine("╚═══════════════════════════════════╝");


            switch (Console.ReadLine()) 
            {
                case "1":
                    Sorting.SortByFileType(rootPath);
                    break;
                case "2":
                    Sorting.SortByLastUsed(rootPath);
                    break;
                case "3":
                    Sorting.SortByLastEdited(rootPath);
                    break;
                default:
                    Console.WriteLine("╔═══════════════════════════════════╗");
                    Console.WriteLine("║    Illegal operation closing...   ║");
                    Console.WriteLine("╚═══════════════════════════════════╝");
                    Thread.Sleep(1000);
                    Environment.Exit(2);
                    break;
            }
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║            ! All Done !           ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
            Console.Read();

        }
    }
}
