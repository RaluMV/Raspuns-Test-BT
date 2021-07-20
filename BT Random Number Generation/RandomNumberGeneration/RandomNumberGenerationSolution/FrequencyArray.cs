using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNumberGeneration.RandomNumberGenerationSolution
{
    public class FrequencyArray
    {
        public int ArrayDimension { get; set; }
        public double[] Array { get; set; }

        public FrequencyArray(int n, double[] array)
        {
            this.ArrayDimension = n;
            this.Array = array;
        }

        public double[] readFrequencyArray(int n)
        {
            double[] frequencyArray = new double[n];
            Console.WriteLine("Please provide the frequencies array's elements;");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("frequencyArray[" + i + "]= ");
                frequencyArray[i] = double.Parse(Console.ReadLine());
            }
            return frequencyArray;
        }

        public void printArray(int[] array)
        {
            Console.WriteLine("The array resulted from the frequency array is the following:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
