﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class DictionaryUtilities
    {

        public static int IndexFinder(dynamic searchedWord, dynamic words)
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

        public static T[] GrowSizeByOne<T>(T[] array)
        {
            int size = array.Length;
            T[] arrayBigger = new T[size + 1];

            for (int index = 0; index < size; index++)
            {
                arrayBigger[index] = array[index];
            }

            return arrayBigger;
        }

        public static T[] ShrinkSizeByOne<T>(T[] array, int removeIndex)
        {
            int size = array.Length;
            T[] arraySmaller = new T[size - 1];

            for (int indexOld = 0, indexNew = 0; indexNew < size - 1; indexOld++, indexNew++)
            {
                if (indexOld != removeIndex)
                    arraySmaller[indexNew] = array[indexOld];
                else indexNew--;
            }

            return arraySmaller;
        }

        public static bool CheckIfWordAlreadyDefined(string word, string[] wordList)
        {
            int index = IndexFinder(word, wordList);

            if (index >= 0)
                return true;
            else
                return false;
        }

        public static void SearchForWord (dynamic dictionary)
        {
            Console.Write("Enter the word you are searching for: ");
            string word = Console.ReadLine();

            if (CheckIfWordAlreadyDefined(word, dictionary.WordListString()))
                Console.WriteLine($"\nDefinition of {word}: {dictionary[word]}\n");
            else
                Console.WriteLine("That word does not exist in the dictionary!\n");
        }

        public static void AddWordAndDefn(dynamic dictionary)
        {
            Console.Write("Enter a word add to the dictionary: ");
            string word = Console.ReadLine();

            if (CheckIfWordAlreadyDefined(word, dictionary.WordListString()))
            {
                Console.WriteLine("\nThe word is already defined in the dictionary.");
                Console.WriteLine($"{word}: {dictionary[word]}\n");
            }
            else
            {
                Console.Write("Add the definition for the word " + word + ": ");
                string definition = Console.ReadLine();

                dictionary[word] = definition;
                Console.WriteLine($"The word \"{word}\" and its definition has been added to the dictionary!\n");
            }
        }

        public static void ChangeDefinition(dynamic dictionary)
        {
            Console.Write("Enter the word you like to modify: ");
            string word = Console.ReadLine();

            if (CheckIfWordAlreadyDefined(word, dictionary.WordListString()))
            {
                Console.Write("Enter the new definition of " + word + ": ");
                string definition = Console.ReadLine();

                dictionary[word] = definition;

                Console.WriteLine($"\n{word}: {dictionary[word]}");
                Console.WriteLine($"The word \"{word}\" has been successfully modified!\n");
            }

            else Console.WriteLine("\nThe word is not defined in the dictionary.\n");
        }

        public static void RemoveWordAndDefn(dynamic dictionary)
        {
            Console.Write("Enter the word you are searching for: ");
            string word = Console.ReadLine();

            if (CheckIfWordAlreadyDefined(word, dictionary.WordListString()))
            {
                dictionary.RemoveWordAndDefn(word);
                Console.WriteLine($"\nThe word \"{word}\" and its definition has been successfully removed from the dictionary.\n");
            }

            else Console.WriteLine("The word you are trying to delete is not defined in the dictionary.\n");
        }
    }
}
