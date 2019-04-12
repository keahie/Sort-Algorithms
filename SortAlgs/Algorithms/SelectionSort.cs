using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgs.Algorithms
{
    class SelectionSort
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

            for (int i = 0; i < array.Length - i; i++)
            {
                int min = int.MaxValue, max = int.MinValue;
                int posMin = -1, posMax = -1;
                for (int j = i; j < array.Length - i; j++)
                {
                    if (array[j] >= min && array[j] <= max)
                    {
                        continue;
                    }

                    if (array[j] < min)
                    {
                        min = array[j];
                        posMin = j;
                    }

                    if (array[j] > max)
                    {
                        max = array[j];
                        posMax = j;
                    }
                }
                int temp = array[i];
                array[i] = array[posMin];
                array[posMin] = temp;
                if (i == posMax)
                {
                    posMax = posMin;
                }

                temp = array[(array.Length - 1) - i];
                array[(array.Length - 1 )- i] = array[posMax];
                array[posMax] = temp;
            }
            return array;
        }
    }
}
