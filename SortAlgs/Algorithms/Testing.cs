using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgs.Algorithms
{
    class Testing
    {
        /// <summary>
        /// Eine Testklasse um zu überprüfen ob das übergebene Array sortiert ist
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public bool Run(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
