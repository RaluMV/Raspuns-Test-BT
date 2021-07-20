using RandomNumberGeneration.RandomNumberGenerationSolution;
using System;

namespace RandomNumberGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] frequencies = new double[2] { 1.0, 2.0 };
            FrequencyArray frequencyArray = new FrequencyArray(frequencies.Length, frequencies);
            RandomNumberGenerationSolutionClass randomGenerator = new RandomNumberGenerationSolutionClass(frequencyArray);
            string[] message = randomGenerator.CalculateProbability(frequencies);
            for(int i=0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }

            double[] frequencies1 = new double[5] { 1.0, 1.0, 1.0, 1.0, 1.0 };
            FrequencyArray frequencyArray1 = new FrequencyArray(frequencies1.Length, frequencies1);
            RandomNumberGenerationSolutionClass randomGenerator1 = new RandomNumberGenerationSolutionClass(frequencyArray1);
            string[] message1 = randomGenerator.CalculateProbability(frequencies1);
            for (int i = 0; i < message1.Length; i++)
            {
                Console.WriteLine(message1[i]);
            }

            double[] frequencies2 = new double[3] { 2.0, 0.0, 2.0};
            FrequencyArray frequencyArray2 = new FrequencyArray(frequencies2.Length, frequencies1);
            RandomNumberGenerationSolutionClass randomGenerator2 = new RandomNumberGenerationSolutionClass(frequencyArray2);
            string[] message2 = randomGenerator.CalculateProbability(frequencies2);
            for (int i = 0; i < message2.Length; i++)
            {
                Console.WriteLine(message2[i]);
            }


        }
    }
}
