using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Fill(numbers);
            BubbleSort(numbers);
            Print(numbers);           
        }

        private static void Fill(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(1, 100);
            }
        }

        private static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int i2 = 0; i2 < array.Length; i2++)
                {
                    if (!(i2 + 1 == array.Length)) { 
                        int current = array[i2];
                        int next = array[i2 + 1];
                        if (current > next)
                        {
                            array[i2] = next;
                            array[i2 + 1] = current;
                        }
                    }
                }
            }
        }

        private static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
