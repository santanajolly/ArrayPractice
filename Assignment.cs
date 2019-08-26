using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Manipulating_Arrays
{
    class Assignment
    {
        public void Display(int[] array)
        {
            Console.Write(string.Join(", ", array));
        }
        public void Count(int[] array)
        {
            Console.WriteLine($"\nThere are {array.Length} values in this array");
        }
        public int Sum(int[] array)
        {
            int sum = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public void Mean(int[] array, int sum)
        {
            double mean = ((double)sum / array.Length);
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The mean is {mean}");
        }
        public void Reverse(int[] array)
        {
            Console.Write("Reverse: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
            }
        }
        public int[] Sort(int[] array)
        {
            int temp = 0;
            Console.Write("\nSort: ");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        //create temp array
        //if statement for string left or right
        public int[] Rotate(int[] array, int shift, string direction)
        {
            Console.Write($"\nRotated {direction} {shift} places: ");
            int[] temp = new int[array.Length];
            if (direction == "right" || direction == "RIGHT")
            {
                for (int i = 0, j = shift; i < array.Length; i++, j++)
                {
                    if (j > array.Length - 1)
                    {
                        j = array.Length - j;
                        temp[j] = array[i];
                    }
                    else
                    {
                        temp[j] = array[i];
                    }
                }
                return array;
            }
            else
            {
                for (int j = 0, i = shift; j < array.Length; i++, j++)
                {
                    if (i > array.Length - 1)
                    {
                        i = array.Length - i;
                        temp[i] = array[j];
                    }
                    else
                    {
                        temp[i] = array[j];
                    }

                }
                
                return array;
            }
        }
    }
}
