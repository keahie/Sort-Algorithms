using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgs.Algorithms
{
    class QuickSort
    {
        /// <summary>
        /// Die Methode um ein Array als Quicksort zu sortieren
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] Run(int[] oldArray)
        {
            int[] array = new int[oldArray.Length];
            Array.Copy(oldArray, 0, array, 0, oldArray.Length);

            Testing testing = new Testing();
            bool valid = testing.Run(array);
            if (valid)
            {
                return array;
            }
            Random random = new Random();
            int count = random.Next(0, array.Length);
            count = array[count];
            List<int> lower = new List<int>(), equal = new List<int>(), higher = new List<int>();
            foreach (var element in array)
            {
                if (element < count)
                {
                    lower.Add(element);
                }
                else if (element > count)
                {
                    higher.Add(element);
                }
                else
                {
                    equal.Add(element);
                }
            }
            lower = Run(lower.ToArray()).ToList();
            higher = Run(higher.ToArray()).ToList();
            int i = 0;
            foreach (var element in lower)
            {
                array[i] = lower[i];
                i++;
            }
            foreach (var element in equal)
            {
                array[i] = element;
                i++;
            }
            foreach (var element in higher)
            {
                array[i] = element;
                i++;
            }
            return array;
        }
    }
}
