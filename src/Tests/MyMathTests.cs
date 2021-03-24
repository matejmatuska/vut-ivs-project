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
            Assert.AreEqual(5, math.Sum(0, 5));
            Assert.AreEqual(-48, math.Sum(-49, 1));
            Assert.AreEqual(-25, math.Sum(-15, -10));
            Assert.AreEqual(-2.50000, math.Sum(-3, +0.50000), Accuracy);
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
                for (double input2 = 186.84; input2 > -153.25; input2 -= 4.2)
                    SumOneValue(math, input1, input2);
            }
        }

        private void SumOneValue(Mymathclass math, double input1, double input2)
        {
            double expected = input1 + input2;
            double result = math.Sum(input1, input2);
            Assert.AreEqual(expected, result, Accuracy);
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
            catch (DivideByZeroException)
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
            Assert.AreEqual(2.50000, math.Div(5, 2), Accuracy);
            //false
            Assert.AreNotEqual(0, math.Div(-50, 2));
            Assert.AreNotEqual(-9, math.Div(-3, -3));
            Assert.AreNotEqual(0.06000, math.Div(1.20000, 2), Accuracy);
            Assert.AreNotEqual(-2, math.Mul(10, 10));


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

        [TestMethod]
        // test factorial
        public void FactTest()
        {
            //create an instance to test
            Mymathclass math = new Mymathclass();
            try
            {
                math.Fact(-8);
            }
            catch (ArgumentOutOfRangeException)
            {

            }

            try
            {
                math.Fact(5.258);
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            //are equal
            Assert.AreEqual(0, math.Fact(1));
            Assert.AreEqual(6, math.Fact(3));
            Assert.AreEqual(362880, math.Fact(9));
            Assert.AreEqual(2.43290e18, math.Fact(20), Accuracy);
            //false
            Assert.AreNotEqual(5, math.Fact(5));
            Assert.AreNotEqual(1, math.Fact(1));
            Assert.AreNotEqual(32, math.Fact(64));


        }
        [TestMethod]
        // test factorial with inputs from range
        public void FactRangeTest()
        {
            // Create an instance to test.
            Mymathclass math = new Mymathclass();

            // Try a range of values.
            for (double input1 = 4; input1 < 18; input1 += 1)
            {
                FactOneValue(math, input1);
            }
        }

        private void FactOneValue(Mymathclass math, double input1)
        {
            double expected = input1;
            for (int i = 1; i < input1; i++)
            {
                expected *= i;

            }
            double result = math.Fact(input1);
            Assert.AreEqual(expected, result, Accuracy);
        }
        [TestMethod]
        // test factorial
        public void PowTest()
        {
            //create an instance to test
            Mymathclass math = new Mymathclass();
            try
            {
                math.Pow(2, -5);
            }
            catch (ArgumentOutOfRangeException)
            {

            }

            try
            {
                math.Pow(14, 2.5);
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            //are equal
            Assert.AreEqual(1, math.Pow(54, 0));
            Assert.AreEqual(1, math.Pow(1, 84));
            Assert.AreEqual(27, math.Pow(3, 3));
            Assert.AreEqual(-16, math.Pow(-4, 2));
            Assert.AreEqual(140.608, math.Pow(5.2, 3), Accuracy);
            //false
            Assert.AreNotEqual(0, math.Pow(2, 0));
            Assert.AreNotEqual(20, math.Pow(1, 20));
            Assert.AreNotEqual(9, math.Pow(3, 3));
            Assert.AreNotEqual(16, math.Pow(-4, 2));
            Assert.AreNotEqual(140.61, math.Pow(5.2, 3), Accuracy);
        }

        [TestMethod]
        // test divison with inputs from range
        public void PowRangeTest()
        {
            // Create an instance to test.
            Mymathclass math = new Mymathclass();

            // Try a range of values.
            for (double input1 = 153.25; input1 < 186.84; input1 += 4.2)
            {
                for (double input2 = 1; input2 < 10; input2++)
                    PowOneValue(math, input1, input2);
            }
        }

        private void PowOneValue(Mymathclass math, double input1, double input2)
        {

            double power(double x, int y)
            {
                if (y == 0)
                    return 1;
                double temp = power(x, y / 2);
                if (y % 2 == 0)
                    return temp * temp;
                else
                {
                    if (y > 0)
                        return x * temp * temp;
                    else
                        return (temp * temp) / x;
                }
            }
            int res = Convert.ToInt32(input2);
            double expected = power(input1, res);
            double result = math.Pow(input1, input2);
            Assert.AreEqual(expected, result, 1e-2);
        }

        [TestMethod]
        // test root function
        public void RootTest()
        {
            //create an instance to test
            Mymathclass math = new Mymathclass();
            try
            {
                math.Pow(-10, 2);
            }
            catch (NotFiniteNumberException)
            {

            }

            try
            {
                math.Pow(14, 0);
            }
            catch (DivideByZeroException)
            {

            }
            //are equal
            //root(x,n) = n √x 
            Assert.AreEqual(7, math.Root(49, 2));
            Assert.AreEqual(3, math.Root(27, 3));
            Assert.AreEqual(5, math.Root(1953125, 9));
            Assert.AreEqual(3.741657, math.Root(14, 2), Accuracy);
            Assert.AreEqual(0, math.Root(0, 0));

            //not equal
            Assert.AreNotEqual(3, math.Root(8, 2));
            Assert.AreNotEqual(-5, math.Root(0, 5));
            Assert.AreNotEqual(3.85243, math.Root(14, 2), Accuracy);
            Assert.AreNotEqual(3.33333, math.Root(10, 3), Accuracy);
            Assert.AreNotEqual(1, math.Root(2, 2), Accuracy);


        }
        [TestMethod]
        //range of values for sqrt function
        public void SqrtRangeTest()
        {
            // Create an instance to test.
            Mymathclass math = new Mymathclass();

            // Try a range of values.
            for (double input1 = 1; input1 < 100; input1++)
                SqrtOneValue(math, input1);

        }

        private void SqrtOneValue(Mymathclass math, double input1)
        {
            double Sqrt(int x)
            {

                double root = 1;
                int i = 0;
                //The Babylonian Method for Computing Square Roots
                while (true)
                {
                    i = i + 1;
                    root = (x / root + root) / 2;
                    if (i == x + 1) { break; }
                }
                return root;
            }
            int res = Convert.ToInt32(input1);
            double expected = Sqrt(res);
            double result = math.Root(input1, 2);
            Assert.AreEqual(expected, result, 1e-2);
        }

        [TestMethod]
        // test discriminant function
        public void DiscTest()
        {
            Mymathclass math = new Mymathclass();
            //are equal
            Assert.AreEqual(76, math.Disc(3, 4, -5));
            Assert.AreEqual(638.4, math.Disc(0.8, 25, -4.2), Accuracy);
            Assert.AreEqual(0, math.Disc(0, 0, 0));
            Assert.AreEqual(0, math.Disc(2, 4, 2));
            Assert.AreEqual(-3, math.Disc(1, 1, 1));
            //are not equal
            Assert.AreNotEqual(-812.5, math.Disc(5, 2, 5),Accuracy);
            Assert.AreNotEqual(-20, math.Disc(352, 2, 5.8), Accuracy);
            Assert.AreNotEqual(1, math.Disc(1, 1, 1));
            Assert.AreNotEqual(8, math.Disc(-8, 0, -80));
            Assert.AreNotEqual(-3.5, math.Disc(25, 18, 1), Accuracy);

        }
    }
}

