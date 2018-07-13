using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class WordUtilities
    {
        public static int IndexFinder<TKey> (TKey searchedWord, TKey[] words)
        {
            dynamic searchWord = searchedWord;
            dynamic wordArray = words;

            int dictLength = words.Length;
            int index;

            for (index = 0; index < dictLength; index++)
            {
                if (searchWord == wordArray[index])
                    break;
                else if (index == dictLength - 1)
                    throw new ArgumentException("Searched word cannot be found", "searchedWord");
            }

            return index;
        }

        public static void AddWord (string firstWord)
        {

        }

    }
}
