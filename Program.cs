using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6A___Manipulating_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[6] { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = new int[5] { 1, 3, 5, 7, 9 };
            int[] arrayC = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            var assignment = new Assignment();
            int sumA = assignment.Sum(arrayA);
            int sumB = assignment.Sum(arrayB);
            int sumC = assignment.Sum(arrayC);


            Console.WriteLine("Array A: ");
            assignment.Display(arrayA);
            assignment.Count(arrayA);
            assignment.Sum(arrayA);
            assignment.Mean(arrayA, sumA);
            assignment.Reverse(arrayA);
            int[] arraySA = assignment.Sort(arrayA);
            assignment.Display(arraySA);
            int shift = 2;
            string direction = "left";
            int[] arrayRA = assignment.Rotate(arrayA, shift, direction);
            assignment.Display(arrayRA);
            

            Console.WriteLine("\n\nArray B: ");
            assignment.Display(arrayB);
            assignment.Count(arrayB);
            assignment.Sum(arrayB);
            assignment.Mean(arrayB, sumB);
            assignment.Reverse(arrayB);
            int[] arraySB = assignment.Sort(arrayB);
            assignment.Display(arraySB);
            shift = 2;
            direction = "right";
            int[] arrayRB = assignment.Rotate(arrayB, shift, direction);
            assignment.Display(arrayRB);

            Console.WriteLine("\n\nArray C: ");
            assignment.Display(arrayC);
            assignment.Count(arrayC);
            assignment.Sum(arrayC);
            assignment.Mean(arrayC, sumC);
            assignment.Reverse(arrayC);
            //int[] arraySC = assignment.Sort(arrayC);
            //assignment.Display(arraySC);
            shift = 4;
            direction = "left";
            int[] arrayRC = assignment.Rotate(arrayC, shift, direction);
            assignment.Display(arrayRC);

        }

    }
}
