using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            InitDictionary.StartMessage();

            IndexerDictionary<string, string> dictionary = new IndexerDictionary<string, string>();
            string programInput;
            
            if (dictionary.EmptyDictionaryChecker())
                InitDictionary.Initialize(dictionary);

            // MAIN PROGRAM //
            while(true)
            {
                Console.WriteLine("1. Search a word\n" 
                                + "2. Add a word and its definition\n" 
                                + "3. Change a word's spelling\n" 
                                + "4. Change a word's definition\n" 
                                + "5. Remove a word\n" 
                                + "6. See all words in the dictionary\n" 
                                + "7. Exit program\n");

                Console.Write("Type the number of your choice: ");
                programInput = Console.ReadLine();

                if (programInput == "1")        DictionaryUtilities.SearchForWord(dictionary);

                else if (programInput == "2")   DictionaryUtilities.AddWordAndDefn(dictionary);

                else if (programInput == "3")   DictionaryUtilities.ChangeSpelling(dictionary);

                else if (programInput == "4")   DictionaryUtilities.ChangeDefinition(dictionary);

                else if (programInput == "5")   DictionaryUtilities.RemoveWordAndDefn(dictionary);

                else if (programInput == "6")   DictionaryUtilities.ShowAllWordsAndDefn(dictionary);

                else if (programInput == "7")   InitDictionary.ExitProgram();

                else                            Console.WriteLine("\nIncorrect choice, try again.");

                Console.Write("Press any key to go back to the main menu: ");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
