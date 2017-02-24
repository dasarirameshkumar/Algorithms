using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sourceArray = new int[] { 4, 1, 9, 6, 8, 3, 2, 8 };
            int min, temp;

            for(int i =0; i< sourceArray.Length-1; i++)
            {
                min = i;
                for(int j=i+1; j<sourceArray.Length; j++)
                {
                   if(sourceArray[j] < sourceArray[min])
                        min = j;
                }

                if(min != i)
                {
                    temp = sourceArray[i];
                    sourceArray[i] = sourceArray[min];
                    sourceArray[min] = temp;
                }
                    
            }
            foreach(int i in sourceArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
