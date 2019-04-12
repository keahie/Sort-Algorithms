using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgs.Algorithms
{
    class BubbleSort
    {
        public int[] Run(int[] array)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, 0, newArray, 0, array.Length);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int x = 0; x < array.Length - 1 - i; x++)
                {
                    if (newArray[x] > newArray[x + 1])
                    {
                        int tmp = newArray[x];
                        newArray[x] = newArray[x + 1];
                        newArray[x + 1] = tmp;
                    }
                }
            }


            return newArray;
        }
    }
}
