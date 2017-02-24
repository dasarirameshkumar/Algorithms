using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        /// <summary>
        /// 1. Sort the elements in an array
        /// 2. Take Mid position of the array and search the 1st half of the array if element is less than mid element else search in the 2nd half
        /// 3. Repeat step2
        /// </summary>
        /// <param name="eleArray"></param>
        /// <param name="eleToSearch"></param>
        /// <returns></returns>
        static int binarySearch(int[] eleArray, int left, int right, int eleToSearch)
        {
            if (left <= right) {
                int midPosition = (left + right) / 2;
                if (eleArray[midPosition] == eleToSearch)
                    return midPosition;

                if (eleArray[midPosition] > eleToSearch)
                    return binarySearch(eleArray, left, midPosition - 1, eleToSearch);

                return binarySearch(eleArray, midPosition + 1, right, eleToSearch);
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] elements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int left = 0;
            int right = elements.Length-1;
            int position = binarySearch(elements, left, right, 10);
            if (position == -1)
                Console.WriteLine("Element is not found");
            else
                Console.WriteLine("Element is found at position " + position);
        }
    }
}
