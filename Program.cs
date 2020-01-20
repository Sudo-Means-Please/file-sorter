using System;
using System.Threading;

namespace Sorter
{
    class Program
    {
        // Add new Class to current Class //
        Sorting Sorting = new Sorting();
        // Main function //
        static void Main()
        {
            // Print Message for "Root-Folder input //
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║       Enter Folder to sort:       ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
            Console.Write("   >");
            // Get "Root-Folder"
            string rootPath = Console.ReadLine();

            // Print sorting-options //
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

            // Switch on users input //
            switch (Console.ReadLine()) 
            {
                // Sort by Filetype //
                case "1":
                    Sorting.SortByFileType(rootPath);
                    break;
                // Sort by Filetype //
                case "2":
                    Sorting.SortByLastUsed(rootPath);
                    break;
                // Sort by Filetype //
                case "3":
                    Sorting.SortByLastEdited(rootPath);
                    break;
                // Print Error-Message and close //
                default:
                    Console.WriteLine("╔═══════════════════════════════════╗");
                    Console.WriteLine("║    Illegal operation closing...   ║");
                    Console.WriteLine("╚═══════════════════════════════════╝");
                    Thread.Sleep(1000);
                    Environment.Exit(2);
                    break;
            }
            // Print Success-Message //
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║            ! All Done !           ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
            Console.Read();

        }
    }
}
