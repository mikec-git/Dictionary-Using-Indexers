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
        public TKey[] words { get; private set; }
        public TValue[] definitions { get; private set; }
        private int index;

        public IndexerDictionary()
        {
            words = new TKey[0];
            definitions = new TValue[0];
        }

        public bool EmptyDictionaryChecker()
        {
            if (words.Length == 0 || definitions.Length == 0)
                return true;
            else
                return false;
        }

        public string[] WordListString()
        {
            return Array.ConvertAll(words, item => Convert.ToString(item));
        }

        // Returns the definition of the user searched word OR adds definition to the searched word
        public TValue this[TKey searchedWord]
        {
            get
            {
                index = DictionaryUtilities.IndexFinder(searchedWord, words);

                if(index >= 0)
                    return definitions[index];
                else
                    throw new ArgumentNullException("The searched word is not defined in the dictionary.");
            }

            set
            {
                index = DictionaryUtilities.IndexFinder(searchedWord, words);

                if(index >= 0)
                    definitions[index] = value;
                else
                {
                    if (words.Length == definitions.Length)
                    {
                        words = DictionaryUtilities.GrowSizeByOne(words);
                        definitions = DictionaryUtilities.GrowSizeByOne(definitions);

                        int newLength = words.Length;
                        words[newLength - 1] = searchedWord;
                        definitions[newLength - 1] = value;
                    }
                    else
                    {
                        Console.WriteLine("There appears to be a mismatch of words to definitions. Program terminating.");
                        Environment.Exit(0);
                    }
                }
            }
        }

        // Removes a word and definition
        public void RemoveWordAndDefn(string word)
        {
            int index = DictionaryUtilities.IndexFinder(word, words);

            words = DictionaryUtilities.ShrinkSizeByOne<TKey>(words, index);
            definitions = DictionaryUtilities.ShrinkSizeByOne<TValue>(definitions, index);
        }
    }
}
