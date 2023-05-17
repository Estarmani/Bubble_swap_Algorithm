using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 23, 45, 67, 87, 90, 80, 34, 12, 32, 11 };
            int temp;
            
            //repeat n-1
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++) 
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;

                    }
                }
            }
            Console.WriteLine(array);
           //for (int i = 0; i < array.Length; i++)
            foreach(int i in array)
            {
                Console.Write(i + " ");
                
            }
            Console.ReadKey();


        }
    }
}
