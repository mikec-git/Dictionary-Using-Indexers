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

        public static void Initialize(dynamic dictionary)
        {
            Console.WriteLine("The dictionary is empty. Would you like to add a word?");
            Console.WriteLine("Type Yes to add a word.");
            Console.WriteLine("Type No to exit.\n");

            while (true)
            {
                Console.Write("Enter here: ");
                string initDictionary = Console.ReadLine();

                if (initDictionary.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to your dictionary!\n");
                    DictionaryUtilities.AddWordAndDefn(dictionary);
                    break;
                }

                else if (initDictionary.Equals("No", StringComparison.OrdinalIgnoreCase))
                    Environment.Exit(0);

                else
                    Console.WriteLine("Incorrect choice, try again.\n");
            }

            Console.Clear();
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
