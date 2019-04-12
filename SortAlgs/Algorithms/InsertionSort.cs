using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgs.Algorithms
{
    class InsertionSort
    {
        /// <summary>
        /// Die Methode um ein Array als Selektionsort zu sortieren
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] Run(int[] oldArray)
        {
            int[] array = new int[oldArray.Length];
            Array.Copy(oldArray, 0, array, 0, oldArray.Length);

            for (int i = 1; i < array.Length; i++)
            {
                int ins = array[i];
                int j = i;
                for (j = i; j > 0 && array[j - 1] > ins; j--)
                {
                    array[j] = array[j - 1];
                }
                array[j] = ins;
            }
            return array;
        }
    }
}
