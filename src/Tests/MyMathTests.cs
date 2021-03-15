using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMath;

namespace MSTest_Test_Project
{
    [TestClass]
    public class MyMathTests
    {
        private const double Accuracy = 1e-5;

        [TestMethod]
        // test summary
        public void SumTest()
        {
            //create an instance to test
            Mymathclass math = new Mymathclass();
            //are equal
            Assert.AreEqual(5,math.Sum(0,5));
            Assert.AreEqual(-48, math.Sum(-49, 1));
            Assert.AreEqual(-25, math.Sum(-15, -10));
            Assert.AreEqual(-2.50000, math.Sum(-3, +0.50000),Accuracy);
            Assert.AreEqual(0, math.Sum(0, 0));
            //false
            Assert.AreNotEqual(352, math.Sum(0, 8));
            Assert.AreNotEqual(-20, math.Sum(-5, -3));
            Assert.AreNotEqual(1.22000, math.Sum(0.60000, 0.60000), Accuracy);
            Assert.AreNotEqual(0, math.Sum(0, 1));
        }
        [TestMethod]
        // test summary with inputs from range
        public void SumRangeTest()
        {
            // Create an instance to test.
            Mymathclass math = new Mymathclass();

            // Try a range of values.
            for (double input1 = -153.25; input1 < 186.84; input1 += 4.2)
            {
                for (double input2 = 186.84; input2> -153.25; input2 -= 4.2)
                    SumOneValue(math,input1,input2);
            }
        }

        private void SumOneValue(Mymathclass math , double input1 , double input2)
        {
            double expected = input1 + input2;
            double result = math.Sum(input1, input2);
            Assert.AreEqual(expected,result,Accuracy);
        }
        [TestMethod]
        //test subtraction
        public void SubTest()
        {
            // Create an instance to test:
            Mymathclass math = new Mymathclass();
            //are equal
            Assert.AreEqual(-5, math.Sub(0, 5));
            Assert.AreEqual(-50, math.Sub(-49, 1));
            Assert.AreEqual(-5, math.Sub(-15, -10));
            Assert.AreEqual(-3.50000, math.Sub(-3, +0.50000), Accuracy);
            Assert.AreEqual(0, math.Sub(0, 0));
            //false
            Assert.AreNotEqual(352, math.Sub(0, 8));
            Assert.AreNotEqual(-20, math.Sub(-5, -3));
            Assert.AreNotEqual(0.0001, math.Sub(0.60000, 0.60000), Accuracy);
            Assert.AreNotEqual(0, math.Sub(0, 1));
        }
        [TestMethod]
        // test subtraction with inputs from range
        public void SubRangeTest()
        {
            // Create an instance to test.
            Mymathclass math = new Mymathclass();

            // Try a range of values.
            for (double input1 = -153.25; input1 < 186.84; input1 += 4.2)
            {
                for (double input2 = 186.84; input2 > -153.25; input2 -= 4.2)
                    SubOneValue(math, input1, input2);
            }
        }

        private void SubOneValue(Mymathclass math, double input1, double input2)
        {
            double expected = input1 - input2;
            double result = math.Sub(input1, input2);
            Assert.AreEqual(expected, result, Accuracy);
        }
        [TestMethod]
        //test multiplication
        public void MulTest()
        {
            // Create an instance to test:
            Mymathclass math = new Mymathclass();
            Assert.AreEqual(-32, math.Mul(-16, 2));
            Assert.AreEqual(0, math.Mul(250000000000, 0));
            Assert.AreEqual(9, math.Mul(-3, -3));
            Assert.AreEqual(2.50000, math.Mul(2, 1.25000), Accuracy);
            Assert.AreEqual(0, math.Mul(0, 0));
            //false
            Assert.AreNotEqual(0, math.Mul(-50, 2));
            Assert.AreNotEqual(-9, math.Mul(-3, -3));
            Assert.AreNotEqual(3.00000, math.Mul(1.20000, 2), Accuracy);
            Assert.AreNotEqual(-2, math.Mul(0, 0));


        }
        [TestMethod]
        // test multiplication with inputs from range
        public void MulRangeTest()
        {
            // Create an instance to test.
            Mymathclass math = new Mymathclass();

            // Try a range of values.
            for (double input1 = -153.25; input1 < 186.84; input1 += 4.2)
            {
                for (double input2 = 186.84; input2 > -153.25; input2 -= 4.2)
                    MulOneValue(math, input1, input2);
            }
        }

        private void MulOneValue(Mymathclass math, double input1, double input2)
        {
            double expected = input1 * input2;
            double result = math.Mul(input1, input2);
            Assert.AreEqual(expected, result, Accuracy);
        }

        [TestMethod]
        //test division
        public void DivTest()
        {
      
            // Create an instance to test:
            Mymathclass math = new Mymathclass();
            //divide by zero 
            try
            {
                math.Div(42, 0);
            }
            catch(DivideByZeroException)
            {

            }
            try
            {
                math.Div(-42, 0);
            }
            catch (DivideByZeroException)
            {

            }
            //are equal
            Assert.AreEqual(2, math.Div(10, 5));
            Assert.AreEqual(1, math.Div(-564, -564));
            Assert.AreEqual(-6, math.Div(42, -7));
            Assert.AreEqual(2.50000, math.Div(5, 2),Accuracy);
            //false
            Assert.AreNotEqual(0, math.Div(-50, 2));
            Assert.AreNotEqual(-9, math.Div(-3, -3));
            Assert.AreNotEqual(0.06000, math.Div(1.20000, 2), Accuracy);
            Assert.AreNotEqual(-2, math.Mul(10,10));


        }
        [TestMethod]
        // test divison with inputs from range
        public void DivRangeTest()
        {
            // Create an instance to test.
            Mymathclass math = new Mymathclass();

            // Try a range of values.
            for (double input1 = -153.25; input1 < 186.84; input1 += 4.2)
            {
                for (double input2 = 186.84; input2 > -153.25; input2 -= 4.2)
                    DivOneValue(math, input1, input2);
            }
        }

        private void DivOneValue(Mymathclass math, double input1, double input2)
        {
            double expected = input1 / input2;
            double result = math.Div(input1, input2);
            Assert.AreEqual(expected, result, Accuracy);
        }

    }
}
