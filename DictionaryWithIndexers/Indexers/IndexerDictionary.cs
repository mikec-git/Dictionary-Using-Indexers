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

        //// Add Word and Definition to Dictionary
        //public void AddWordAndDefn(TKey userWord, TValue userDefinition)
        //{
        //    DictionaryUtilities.GrowSizeByOne<TKey, TValue>(words, definitions, out words, out definitions);

        //    // Add the word and definition to the end of the dictionary
        //    words[words.Length - 1] = userWord;
        //    definitions[words.Length - 1] = userDefinition;
            
        //}
        

        // Returns the definition of the user searched word OR adds definition to the searched word
        public TValue this[TKey searchedWord]
        {
            get
            {
                index = DictionaryUtilities.IndexFinder(searchedWord, words);
                return definitions[index];
            }
            set
            {
                index = DictionaryUtilities.IndexFinder(searchedWord, words);

                if (index >= 0)
                {
                    definitions[index] = value;
                }
                else
                {
                    DictionaryUtilities.GrowSizeByOne(words, definitions, out words, out definitions);
                    words[words.Length - 1] = searchedWord;
                    definitions[words.Length - 1] = value;
                }
            }
        }
    }
}
