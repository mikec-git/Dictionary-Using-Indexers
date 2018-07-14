using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class DictionaryUtilities
    {
        public static int IndexFinder (dynamic searchedWord, dynamic words)
        {
            int dictLength = words.Length;
            if (dictLength == 0)
                return -1; // Means nothing in the dictionary yet

            int index;
            string searchWord = Convert.ToString(searchedWord);

            for (index = 0; index <= dictLength; index++)
            {
                if (index != dictLength)
                {
                    if(searchWord.Equals(Convert.ToString(words[index]), StringComparison.OrdinalIgnoreCase))
                        break;
                }
                else if (index == dictLength)
                    return -1;
            }

            return index;
        }



        public static void GrowSizeByOne<TKey, TValue> (TKey[] words, TValue[] definitions, out TKey[] wordsBigger, out TValue[] definitionsBigger)
        {
            wordsBigger = default(TKey[]);
            definitionsBigger = default(TValue[]);

            if (words.Length == definitions.Length)
            {
                int size = words.Length;
                wordsBigger = new TKey[size + 1];
                definitionsBigger = new TValue[size + 1];

                for(int count = 0; count < size; count++)
                {
                    wordsBigger[count] = words[count];
                    definitionsBigger[count] = definitions[count];
                }
            }
            else
            {
                Console.WriteLine("There appears to be a mismatch of words to definitions. Program Terminating.");
                Environment.Exit(0);
            }
        }
    }
}
