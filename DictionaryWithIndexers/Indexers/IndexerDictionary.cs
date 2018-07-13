using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Indexers;

namespace Indexers
{
    public class IndexerDictionary<TKey, TValue>
    {
        private TKey[] words;
        private TValue[] definitions;
        private int index;
        private string userWord, definition;

        public IndexerDictionary()
        {
            words = new TKey[0];
            definitions = new TValue[0];
        }

        // Checks if dictionary is empty or not
        public bool EmptyDictionaryChecker()
        {
            if (words.Length == 0 || definitions.Length == 0)
                return true;
            else
                return false;
        }

        // Returns the definition of the user searched word OR adds definition to the searched word
        public TValue this[TKey searchedWord]
        {
            get
            {
                index = DictionaryUtilities.IndexFinder<TKey>(searchedWord, words);
                return definitions[index];
            }
            set
            {
                index = DictionaryUtilities.IndexFinder<TKey>(searchedWord, words);
                definitions[index] = value;
            }
        }

        // Add Word and Definition to Dictionary
        public void AddWordAndDefn(IndexerDictionary<TKey,TValue> dictionary, TKey userWord, TValue userDefinition)
        {
            // First grow dictionary array size by 1
            DictionaryUtilities.GrowSizeByOne<TKey, TValue>(dictionary.words, dictionary.definitions, out dictionary.words, out dictionary.definitions);

            // Add the word and definition to the dictionary
            dictionary.words[dictionary.words.Length - 1] = userWord;
            dictionary[userWord] = userDefinition;
            
            // Add event here to link to sorter algorithm
            // ............... //
        }
       
    }
}
