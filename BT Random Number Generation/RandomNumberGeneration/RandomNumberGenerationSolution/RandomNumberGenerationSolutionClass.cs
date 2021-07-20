using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNumberGeneration.RandomNumberGenerationSolution
{
    public class RandomNumberGenerationSolutionClass
    {
        private FrequencyArray _frequencyArray;

        public RandomNumberGenerationSolutionClass(FrequencyArray frequencyArray)
        {
            this._frequencyArray = frequencyArray;
        }


        /*This method computes the GCD of two double numbers
         * Input parameters: a-first number. Type: double
         *                   b-second number. Type: double
         * Output: returns the gcd of a and b. Type: double
         */
        public double GreatCommonDivisor(double a, double b)
        {
            double r;
            r = a % b;
            if (r != 0)
                return GreatCommonDivisor(b, r);
            else
                return b;
        }


        /*This method generates the array of integers from the given frequency array
         * Input parameters: dim-the integers array's dimension. Type: int
         *                   frequencyArray-the array containing the frequencies. Type: double[]
         * Output: returns the arrayOfIntegers. Type:int[] 
         */
        public int[] GenerateTheArrayOnIntegers(int dim, double[] frequencyArray)
        {
            int k = 0;
            int[] arrayOfIntegers = new int[dim];
            for (int i = 0; i < frequencyArray.Length; i++)
            {
                for (double j = 0; j < frequencyArray[i]; j++)
                {
                    arrayOfIntegers[k] = i;
                    k++;
                }
            }
            return arrayOfIntegers;
        }


        /*This method computes the probability for numbers with the given distribution to be generated
         * Input parameters: frequencyArray-the array containing the distribution. Type: double[]
         * Output parameters: returns the probability for each number to be generated. Type: string[]
         */
        public string[] CalculateProbability(double[] frequencyArray)
        {
            //calculates the sum of all the elements 
            // from the frequency array
            
            double sum = 0;
            for (int i = 0; i < frequencyArray.Length; i++)
            {
                sum += frequencyArray[i];
            }
            
            //generates and prints the array of integers.
            // I didn't know if this was required, 
            // but I printed that array anyway
            // in order to visualize the probabilities for each element better 

            int dim = Convert.ToInt32(sum);
            Console.WriteLine("The array of integers generated from the frequency array: ");
            int[] arrayOfIntegers = this.GenerateTheArrayOnIntegers(dim, frequencyArray);
            this._frequencyArray.printArray(arrayOfIntegers);
            string[] messages = new string[dim];
            // calculates the probability for each element from the
            // frequency array and if the fraction resulted can be simplified
            // it calculated the GCD in order to do so
            // and it outputs to the console the final results

            for (int i = 0; i < frequencyArray.Length; i++)
            {
                if (frequencyArray[i] != 0)
                {
                    double simplification = this.GreatCommonDivisor(frequencyArray[i], sum);
                    if ((frequencyArray[i] / simplification == 0) && (sum / simplification == 0))
                    { 
                        messages[i]="Probability for element " + i + " is " + frequencyArray[i] / simplification + "/" + sum / simplification;
                    }
                    else
                    {
                        messages[i]="Probability for element " + i + " is " + frequencyArray[i] + "/" + sum;
                    }
                }

            }
            return messages;

        }
    }
}
