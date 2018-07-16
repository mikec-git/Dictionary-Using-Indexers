using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class AlphabeticalSorter
    {
        // Refer to very helpful video: https://www.youtube.com/watch?v=MZaf_9IZCrc

        private int pivot, leftPoint, rightPoint = 0;
        private string[] partition;

        public static void Quicksort<TKey,TValue> (TKey[] words, TValue[] definitions, int left, int pivot)
        {
            if (left < pivot)
            {
                int partitionIndex = Partition(words, definitions, left, pivot);

                Quicksort<TKey, TValue>(words, definitions, left, partitionIndex - 1);
                Quicksort<TKey, TValue>(words, definitions, partitionIndex + 1, pivot);
            }

        }

        // This algorithm will be using quicksort 
        public static int Partition<TKey, TValue> (TKey[] words, TValue[] right, int left, int pivot)
        {
            int i = left - 1;
            int partitionIndex;
            TKey pivotWord = words[pivot];
            TKey tempWord, currentWord;


            for(int j = left; j < pivot; j++)
            {
                currentWord = words[j];

                if (CompareStringSpelling(currentWord, pivotWord))
                {
                    i++;
                    if (i != j)
                    {
                        tempWord = currentWord;
                        words[j] = words[i];
                        words[i] = tempWord;
                    }
                }
            }

            i++;
            tempWord = pivotWord;
            words[pivot] = words[i];
            words[i] = tempWord;

            return partitionIndex = i;            
        }

        private static bool CompareStringSpelling (dynamic word, dynamic pivotWord)
        {
            int maxLength = Math.Max(word.Length, pivotWord.Length);

            if (String.Compare(word, 0, pivotWord, 0, maxLength, true, new CultureInfo("en-US")) < 0)
                return true;
            else
                return false;
        }
    }
}
