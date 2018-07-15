using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class InitDictionary
    {
        public static void StartMessage()
        {
            Console.Title = "Mike's Dictionary";
            Console.WriteLine("This program is a user-defined dictionary.");
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Initialize()
        {
            Console.WriteLine("The dictionary is empty. Would you like to add a definition?");
            Console.WriteLine("Type Yes to add a definition.\nType No to exit the dictionary.\n");

            while (true)
            {
                Console.Write("Enter here: ");
                string initDictionary = Console.ReadLine();

                if (initDictionary.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to your dictionary!\n");
                    break;
                }

                else if (initDictionary.Equals("No", StringComparison.OrdinalIgnoreCase))
                    Environment.Exit(0);

                else
                    Console.WriteLine("Incorrect choice, try again.\n");
            }
        }

        public static void ExitProgram()
        {
            Console.WriteLine("Are you sure? (Y/N)");
            string programInput = Console.ReadLine();

            if (programInput.Equals("Y", StringComparison.OrdinalIgnoreCase))
                Environment.Exit(0);
        }
    }
}
