using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public TValue this[TKey searchedWord]
        {
            get
            {
                index = WordUtilities.IndexFinder<TKey>(searchedWord, words);
                return definitions[index];
            }
            set
            {
                index = WordUtilities.IndexFinder<TKey>(searchedWord, words);
                definitions[index] = value;
            }
        }
    }
}
