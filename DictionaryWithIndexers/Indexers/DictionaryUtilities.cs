using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class DictionaryUtilities
    {
        private static string word, definition; 
        
        public static int IndexFinder (dynamic searchedWord, dynamic words)
        {
            int dictLength = words.Length;            
            if (dictLength == 0) return -1; // Means nothing in the dictionary yet

            int index;
            string searchWord = Convert.ToString(searchedWord);

            for (index = 0; index <= dictLength; index++)
            {
                if (index != dictLength)
                {
                    if (searchWord.Equals(Convert.ToString(words[index]), StringComparison.OrdinalIgnoreCase))
                        break;
                }
                else if (index == dictLength)
                    return -1;  // Returns value of -1 if the word is not defined in the dictionary
            }

            return index;
        }

        public static T[] GrowSizeByOne<T> (T[] array)
        {
            int size = array.Length;
            T[] arrayBigger = new T[size + 1];

            for (int index = 0; index < size; index++)
            {
                arrayBigger[index] = array[index];
            }
            return arrayBigger;
        }

        private static bool CheckIfWordAlreadyDefined(string word, string[] wordList)
        {
            int index = IndexFinder(word, wordList);

            if (index >= 0)
                return true;
            else
                return false;
        }


        public static void SearchForWord (dynamic dictionary, string[] wordList)
        {
            Console.Write("Enter the word you are searching for: ");
            word = Console.ReadLine();

            if (CheckIfWordAlreadyDefined(word, wordList))
                Console.WriteLine($"\nDefinition of {word}: {dictionary[word]}\n");
            else
                Console.WriteLine("That word does not exist in the dictionary!\n");
        }

        public static void AddWordAndDefn(dynamic dictionary, string[] wordList)
        {
            Console.Write("Enter a word add to the dictionary: ");
            word = Console.ReadLine();

            if (CheckIfWordAlreadyDefined(word, wordList))
            {
                Console.WriteLine("\nThe word is already defined in the dictionary.");
                Console.WriteLine($"{word}: {dictionary[word]}\n");
            }
            else
            {
                Console.Write("Add the definition for the word " + word + ": ");
                definition = Console.ReadLine();

                dictionary[word] = definition;
                Console.WriteLine($"The word \"{word}\" and its definition has been added to the dictionary!\n");
            }
        }

        public static void ChangeDefinition(dynamic dictionary, string[] wordList)
        {
            Console.Write("Enter the word you like to modify: ");
            word = Console.ReadLine();

            if (CheckIfWordAlreadyDefined(word, wordList))
            {
                Console.Write("Enter the new definition of " + word + ": ");
                definition = Console.ReadLine();

                dictionary[word] = definition;

                Console.WriteLine($"\n{word}: {dictionary[word]}");
                Console.WriteLine($"The word \"{word}\" has been successfully modified!\n");
            }
            else
                Console.WriteLine("\nThe word is not defined in the dictionary.\n");
        }

        public static void RemoveWordAndDefn(dynamic dictionary, string[] wordList)
        {
            Console.Write("Enter the word to remove from the dictionary: ");
            word = Console.ReadLine();

            if (CheckIfWordAlreadyDefined(word, wordList))
            {
                int index = IndexFinder(word, wordList);
                int size = wordList.Length;
            }

            else
                Console.WriteLine("That word does not exist in the dictionary!\n");

            

            
        }
    }
}
