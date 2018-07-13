using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class InitDictionary
    {
        public static void Begin()
        {
            while (true)
            {
                string initDictionary = Console.ReadLine();
                if (initDictionary.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to your dictionary!");
                    break;
                }
                else if (initDictionary.Equals("No", StringComparison.OrdinalIgnoreCase))
                    Environment.Exit(0);
                else
                    Console.WriteLine("Incorrect choice, try again.");
            }
        }
    }
}
