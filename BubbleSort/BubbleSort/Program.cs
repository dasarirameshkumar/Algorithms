using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static int[] bubbleSort(int[] sourceArray)
        {
            for(int i=0; i< sourceArray.Length; i++)
            {
                for(int j=0; j<sourceArray.Length-i-1; j++)
                {
                    if (sourceArray[j] > sourceArray[j + 1])
                    {
                        int temp = sourceArray[j];
                        sourceArray[j] = sourceArray[j + 1];
                        sourceArray[j + 1] = temp;
                    }
                }
            }

            return sourceArray;
        }

        static void Main(string[] args)
        {
            int[] sourceArray = new int[] { 6, 3, 9, 6, 8, 1, 7, 10 };
            int[] resultArray = bubbleSort(sourceArray);
            foreach(int i in resultArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
