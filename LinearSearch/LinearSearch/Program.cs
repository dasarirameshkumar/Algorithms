using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{        
    class Program
    {
        static int linearSearch(int[] eleArray, int eleToSearch)
        {
            int iResult = -1;
            for (int i = 0; i < eleArray.Length; i++)
            {
                if (eleArray[i] == eleToSearch)
                {
                    iResult = i;
                    break;
                }
            }
            return iResult;
        }

        static void Main(string[] args)
        {
                int[] elements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int position = linearSearch(elements, 1);
                if (position == -1)
                    Console.WriteLine("Element is not found");
                else
                    Console.WriteLine("Element is found at position: " + position);
        }
    }
}
