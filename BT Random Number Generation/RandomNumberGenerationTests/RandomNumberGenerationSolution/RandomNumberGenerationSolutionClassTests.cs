using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomNumberGeneration.RandomNumberGenerationSolution;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNumberGeneration.RandomNumberGenerationSolution.Tests
{
    [TestClass()]
    public class RandomNumberGenerationSolutionClassTests
    {

        [TestMethod()]
        public void GreatCommonDivisorAreEqualTest()
        {
            double[] frequencies = new double[2] { 1.0,2.0};
            FrequencyArray frequencyArray = new FrequencyArray(2,frequencies);
            RandomNumberGenerationSolutionClass randomGenerator = new RandomNumberGenerationSolutionClass(frequencyArray);
            Assert.AreEqual(randomGenerator.GreatCommonDivisor(12,6),6);
        }

        [TestMethod()]
        public void GreatCommonDivisorNotEqualTest()
        {
            double[] frequencies = new double[2] { 1.0, 2.0 };
            FrequencyArray frequencyArray = new FrequencyArray(2, frequencies);
            RandomNumberGenerationSolutionClass randomGenerator = new RandomNumberGenerationSolutionClass(frequencyArray);
            Assert.AreNotEqual(randomGenerator.GreatCommonDivisor(12,6),2);
        }

        [TestMethod()]
        public void CalculateRightProbabilityTest()
        {
            double[] frequencies = new double[2] { 1.0, 2.0 };
            FrequencyArray frequencyArray = new FrequencyArray(2, frequencies);
            RandomNumberGenerationSolutionClass randomGenerator = new RandomNumberGenerationSolutionClass(frequencyArray);
            string outputMessage1_1 = "Probability for element 0 is 1/3";
            string outputMessage1_2 = "Probability for element 1 is 2/3";
            string[] messages = randomGenerator.CalculateProbability(frequencies);
            Assert.AreEqual(messages[0],outputMessage1_1);
            Assert.AreEqual(messages[1], outputMessage1_2);


            double[] frequencies1 = new double[5] { 1.0, 1.0, 1.0, 1.0, 1.0 };
            FrequencyArray frequencyArray1 = new FrequencyArray(2, frequencies);
            RandomNumberGenerationSolutionClass randomGenerator1 = new RandomNumberGenerationSolutionClass(frequencyArray1);
            string outputMessage2_1 = "Probability for element 0 is 1/5";
            string outputMessage2_2 = "Probability for element 1 is 1/5";
            string outputMessage2_3 = "Probability for element 2 is 1/5";
            string outputMessage2_4 = "Probability for element 3 is 1/5";
            string outputMessage2_5 = "Probability for element 4 is 1/5";
            string[] messages2 = randomGenerator1.CalculateProbability(frequencies1);
            Assert.AreEqual(messages2[0], outputMessage2_1);
            Assert.AreEqual(messages2[1], outputMessage2_2);
            Assert.AreEqual(messages2[2], outputMessage2_3);
            Assert.AreEqual(messages2[3], outputMessage2_4);
            Assert.AreEqual(messages2[4], outputMessage2_5);

             double[] frequencies2 = new double[3] { 2.0, 0.0 ,2.0 };
             FrequencyArray frequencyArray2 = new FrequencyArray(2, frequencies2);
             RandomNumberGenerationSolutionClass randomGenerator2 = new RandomNumberGenerationSolutionClass(frequencyArray2);
             string outputMessage3_1 = "Probability for element 0 is 2/4";
             string outputMessage3_2 = "Probability for element 2 is 2/4";
             string[] messages3 = randomGenerator2.CalculateProbability(frequencies2);
             Assert.AreEqual(messages3[0],outputMessage3_1);
             Assert.AreEqual(messages3[2],outputMessage3_2);

        }

        [TestMethod()]
        public void CalculateWrongProbabilityTest()
        {
            double[] frequencies = new double[2] { 1.0, 2.0 };
            FrequencyArray frequencyArray = new FrequencyArray(2, frequencies);
            RandomNumberGenerationSolutionClass randomGenerator = new RandomNumberGenerationSolutionClass(frequencyArray);
            string outputMessage1_1 = "Probability for element 0 is 1/4";
            string outputMessage1_2 = "Probability for element 1 is 2/2";
            string[] messages = randomGenerator.CalculateProbability(frequencies);
            Assert.AreNotEqual(messages[0], outputMessage1_1);
            Assert.AreNotEqual(messages[1], outputMessage1_2);


            double[] frequencies1 = new double[5] { 1.0, 1.0, 1.0, 1.0, 1.0 };
            FrequencyArray frequencyArray1 = new FrequencyArray(2, frequencies);
            RandomNumberGenerationSolutionClass randomGenerator1 = new RandomNumberGenerationSolutionClass(frequencyArray1);
            string outputMessage2_1 = "Probability for element 0 is 7/5";
            string outputMessage2_2 = "Probability for element 1 is 5/5";
            string outputMessage2_3 = "Probability for element 2 is 2/5";
            string outputMessage2_4 = "Probability for element 3 is 6/5";
            string outputMessage2_5 = "Probability for element 4 is 0/5";
            string[] messages2 = randomGenerator1.CalculateProbability(frequencies1);
            Assert.AreNotEqual(messages2[0], outputMessage2_1);
            Assert.AreNotEqual(messages2[1], outputMessage2_2);
            Assert.AreNotEqual(messages2[2], outputMessage2_3);
            Assert.AreNotEqual(messages2[3], outputMessage2_4);
            Assert.AreNotEqual(messages2[4], outputMessage2_5);

            double[] frequencies2 = new double[3] { 2.0, 0.0, 2.0 };
            FrequencyArray frequencyArray2 = new FrequencyArray(2, frequencies2);
            RandomNumberGenerationSolutionClass randomGenerator2 = new RandomNumberGenerationSolutionClass(frequencyArray2);
            string outputMessage3_1 = "Probability for element 0 is 1/4";
            string outputMessage3_2 = "Probability for element 2 is 3/4";
            string[] messages3 = randomGenerator2.CalculateProbability(frequencies2);
            Assert.AreNotEqual(messages3[0], outputMessage3_1);
            Assert.AreNotEqual(messages3[2], outputMessage3_2);

        }

    }
}