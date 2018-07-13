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
            int dictLength = words.Length - 1;
            int index;

            for (index = 0; index <= dictLength; index++)
            {
                if (EqualityComparer<TKey>.Default.Equals(searchedWord, words[index]))
                    break;
                else if (index == dictLength)
                    throw new ArgumentException("Unknown searched word", "searchedWord");
            }

            return index;
        }
    }
}
