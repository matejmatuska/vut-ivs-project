using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathLib;

namespace MSTest_Test_Project
{
    /**
    * Math Library tests.
    */
    [TestClass]
    public class MyMathLibTests
    {
        private const double Accuracy = 1e-5;

        /**
        * Test for summary .
        */
        [TestMethod]
        public void SumTest()
        {
         
            //are equal
            Assert.AreEqual(5, MathLib.Sum(0, 5));
            Assert.AreEqual(-48, MathLib.Sum(-49, 1));
            Assert.AreEqual(-25, MathLib.Sum(-15, -10));
            Assert.AreEqual(-2.50000, MathLib.Sum(-3, +0.50000), Accuracy);
            Assert.AreEqual(0, MathLib.Sum(0, 0));
            Assert.AreEqual(350000000, MathLib.Sum(175000000, 175000000));
            Assert.AreEqual(-182.52697, MathLib.Sum(-3, -179.52697), Accuracy);
            Assert.AreEqual(-300000, MathLib.Sum(-400000, 100000));
            //false
            Assert.AreNotEqual(352, MathLib.Sum(0, 8));
            Assert.AreNotEqual(-20, MathLib.Sum(-5, -3));
            Assert.AreNotEqual(1.22000, MathLib.Sum(0.60000, 0.60000), Accuracy);
            Assert.AreNotEqual(0, MathLib.Sum(0, 1));
            Assert.AreNotEqual(250000000, MathLib.Sum(10000000, 15000000));
            Assert.AreNotEqual(-512.25252, MathLib.Sum(312.25252, -200));
            Assert.AreNotEqual(0, MathLib.Sum(-0.1, 0.11), Accuracy);
            Assert.AreNotEqual(10, MathLib.Sum(30, 20));
        }

        /**
        * Test for subtraction .
        */
        [TestMethod]
        public void SubTest()
        {
          
            
            //are equal
            Assert.AreEqual(-5, MathLib.Sub(0, 5));
            Assert.AreEqual(-50, MathLib.Sub(-49, 1));
            Assert.AreEqual(-5, MathLib.Sub(-15, -10));
            Assert.AreEqual(-3.50000, MathLib.Sub(-3, +0.50000), Accuracy);
            Assert.AreEqual(0, MathLib.Sub(0, 0));
            Assert.AreEqual(1880002536, MathLib.Sub(1880002694, 158));
            Assert.AreEqual(300, MathLib.Sub(-150, -450));
            Assert.AreEqual(2.99999, MathLib.Sub(3, 0.00001), Accuracy);
            //false
            Assert.AreNotEqual(352, MathLib.Sub(0, 8));
            Assert.AreNotEqual(-20, MathLib.Sub(-5, -3));
            Assert.AreNotEqual(0.0001, MathLib.Sub(0.60000, 0.60000), Accuracy);
            Assert.AreNotEqual(0, MathLib.Sub(0, 1));
            Assert.AreNotEqual(200000000, MathLib.Sub(300000000, 1));
            Assert.AreNotEqual(2.99999, MathLib.Sub(3, 0.1111111), Accuracy);
            Assert.AreNotEqual(-145, MathLib.Sub(-14, 5));
            Assert.AreNotEqual(1, MathLib.Sub(0, 0));

        }
        /**
        * Test for multiplication.
        */
        [TestMethod]
        public void MulTest()
        {
          
            Assert.AreEqual(-32, MathLib.Mul(-16, 2));
            Assert.AreEqual(0, MathLib.Mul(250000000000, 0));
            Assert.AreEqual(9, MathLib.Mul(-3, -3));
            Assert.AreEqual(2.50000, MathLib.Mul(2, 1.25000), Accuracy);
            Assert.AreEqual(0, MathLib.Mul(0, 0));
            Assert.AreEqual(-1.91265738124716e10, MathLib.Mul(-125.2569, 152698764),Accuracy);
            Assert.AreEqual(2.56984, MathLib.Mul(1.25, 2.055872), Accuracy);
            Assert.AreEqual(30, MathLib.Mul(300, 0.100));
            //false
            Assert.AreNotEqual(0, MathLib.Mul(-50, 2));
            Assert.AreNotEqual(-9, MathLib.Mul(-3, -3));
            Assert.AreNotEqual(3.00000, MathLib.Mul(1.20000, 2), Accuracy);
            Assert.AreNotEqual(-2, MathLib.Mul(0, 0));
            Assert.AreNotEqual(15000000, MathLib.Mul(27500, 2));
            Assert.AreNotEqual(14.01, MathLib.Mul(7, 2), Accuracy);
            Assert.AreNotEqual(-1, MathLib.Mul(0, 0));
            Assert.AreNotEqual(-154.2569, MathLib.Mul(-12458.236, 2546.269),Accuracy);

        }

        /**
        * Test for division.
        */

        [TestMethod]
        public void DivTest()
        {

          
            //divide by zero 
            try
            {
                MathLib.Div(42, 0);
            }
            catch (DivideByZeroException)
            {

            }
            try
            {
                MathLib.Div(-42, 0);
            }
            catch (DivideByZeroException)
            {

            }
            //are equal
            Assert.AreEqual(2, MathLib.Div(10, 5));
            Assert.AreEqual(1, MathLib.Div(-564, -564));
            Assert.AreEqual(-6, MathLib.Div(42, -7));
            Assert.AreEqual(2.50000, MathLib.Div(5, 2), Accuracy);
            Assert.AreEqual(300000000, MathLib.Div(30, 0.0000001),Accuracy);
            Assert.AreEqual(0, MathLib.Div(0, 5));
            Assert.AreEqual(3.230383522, MathLib.Div(10.52698, 3.25874),Accuracy);  
            Assert.AreEqual(62.5, MathLib.Div(-125, -2), Accuracy);

            //false
            Assert.AreNotEqual(0, MathLib.Div(-50, 2));
            Assert.AreNotEqual(-9, MathLib.Div(-3, -3));
            Assert.AreNotEqual(0.06000, MathLib.Div(1.20000, 2), Accuracy);
            Assert.AreNotEqual(-2, MathLib.Mul(10, 10));
            Assert.AreNotEqual(3.234383522, MathLib.Div(10.52698, 3.25784), Accuracy);
            Assert.AreNotEqual(1, MathLib.Div(1, 5));
            Assert.AreNotEqual(15.41677, MathLib.Div(185, 12), Accuracy);
            Assert.AreNotEqual(15000000, MathLib.Div(15000000000, 1));
        }

        /**
        * Test for factorial.
        */
        [TestMethod]
        public void FactTest()
        {
           
            try
            {
                MathLib.Fact(-8);
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                MathLib.Fact(5.258);
            }
            catch (InvalidOperationException)
            {

            }
           
            //are equal
            Assert.AreEqual(1, MathLib.Fact(1));
            Assert.AreEqual(6, MathLib.Fact(3));
            Assert.AreEqual(362880, MathLib.Fact(9));
            Assert.AreEqual(2.43290200817664e18, MathLib.Fact(20), Accuracy);
            Assert.AreEqual(1, MathLib.Fact(0));
            Assert.AreEqual(2, MathLib.Fact(2));
            Assert.AreEqual(24, MathLib.Fact(4));
            Assert.AreEqual(120, MathLib.Fact(5));
            //false
            Assert.AreNotEqual(5, MathLib.Fact(5));
            Assert.AreNotEqual(0, MathLib.Fact(1));
            Assert.AreNotEqual(32, MathLib.Fact(64));
            Assert.AreNotEqual(0, MathLib.Fact(0));
            Assert.AreNotEqual(3628800, MathLib.Fact(9));
            Assert.AreNotEqual(8.71783e10, MathLib.Fact(14), Accuracy);
            Assert.AreNotEqual(-120, MathLib.Fact(5));
            Assert.AreNotEqual(55, MathLib.Fact(5));

        }
        /**
        * Test for exponentiation.
        */
        [TestMethod]
        public void PowTest()
        {
           
            try
            {
                MathLib.Pow(2, -5);
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                MathLib.Pow(14, 2.5);
            }
            catch (InvalidOperationException)
            {

            }
            try
            {
                MathLib.Pow(0, 0);
            }
            catch (InvalidOperationException)
            {

            }
            //are equal
            Assert.AreEqual(1, MathLib.Pow(54, 0));
            Assert.AreEqual(1, MathLib.Pow(1, 84));
            Assert.AreEqual(27, MathLib.Pow(3, 3));
            Assert.AreEqual(16, MathLib.Pow(-4, 2));
            Assert.AreEqual(140.608, MathLib.Pow(5.2, 3), Accuracy);
            Assert.AreEqual(6.979147079584381377970176e42, MathLib.Pow(240, 18),Accuracy);
            Assert.AreEqual(643.586161, MathLib.Pow(25.369, 2), Accuracy);
            Assert.AreEqual(-10604499373, MathLib.Pow(-13, 9), Accuracy);
            //false
            Assert.AreNotEqual(0, MathLib.Pow(2, 0));
            Assert.AreNotEqual(20, MathLib.Pow(1, 20));
            Assert.AreNotEqual(9, MathLib.Pow(3, 3));
            Assert.AreNotEqual(-16, MathLib.Pow(-4, 2));
            Assert.AreNotEqual(140.61, MathLib.Pow(5.2, 3), Accuracy);
            Assert.AreNotEqual(-42, MathLib.Pow(42,1));
            Assert.AreNotEqual(4.12549e38, MathLib.Pow(132, 5), Accuracy);
            Assert.AreNotEqual(-300, MathLib.Pow(-14.42, 3));
        }

        /**
        * Test for root function.
        */
        [TestMethod]
        public void RootTest()
        {
           
            try
            {
                MathLib.Root(-10, 2);
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                MathLib.Root(14, 0);
            }
            catch (InvalidOperationException)
            {

            }
            //are equal
            //root(x,n) = n √x 
            Assert.AreEqual(7, MathLib.Root(49, 2));
            Assert.AreEqual(-3, MathLib.Root(-27, 3));
            Assert.AreEqual(5, MathLib.Root(390625, 8));
            Assert.AreEqual(3.741657, MathLib.Root(14, 2), Accuracy);
            Assert.AreEqual(0, MathLib.Root(0, 0));
            Assert.AreEqual(0.1111111, MathLib.Root(81,-2), Accuracy);
            Assert.AreEqual(13, MathLib.Root(815730721, 8));
            Assert.AreEqual(0.25, MathLib.Root(0.0625, 2), Accuracy);


            //not equal
            Assert.AreNotEqual(3, MathLib.Root(8, 2));
            Assert.AreNotEqual(-5, MathLib.Root(0, 5));
            Assert.AreNotEqual(3.85243, MathLib.Root(14, 2), Accuracy);
            Assert.AreNotEqual(3.33333, MathLib.Root(10, 3), Accuracy);
            Assert.AreNotEqual(1, MathLib.Root(2, 2), Accuracy);
            Assert.AreNotEqual(1.02135, MathLib.Root(81, 81), Accuracy);
            Assert.AreNotEqual(-2, MathLib.Root(4, 2));
            Assert.AreNotEqual(-1.2569, MathLib.Root(-6.254, 7), Accuracy);

        }

        /**
        * Test for modulo.
        */
        [TestMethod]
        public void ModTest()
        {
            try
            {
                MathLib.Mod(42, 0);
            }
            catch (DivideByZeroException)
            {

            }

            //are equal
            Assert.AreEqual(0, MathLib.Mod(0, 15));
            Assert.AreEqual(2, MathLib.Mod(10, 4));
            Assert.AreEqual(-10, MathLib.Mod(-36, -13));
            Assert.AreEqual(-4, MathLib.Mod(-2000000, 127));
            Assert.AreEqual(1, MathLib.Mod(11, 2.5));
            Assert.AreEqual(50.2, MathLib.Mod(402.3, 50.3), Accuracy);
            Assert.AreEqual(-0.04, MathLib.Mod(-12, 0.13), Accuracy);
            Assert.AreEqual(18, MathLib.Mod(8874, 123));
            //not equal
            Assert.AreNotEqual(15, MathLib.Mod(0, 15));
            Assert.AreNotEqual(2.01, MathLib.Mod(10, 4));
            Assert.AreNotEqual(10, MathLib.Mod(-36, -13));
            Assert.AreNotEqual(1, MathLib.Mod(-9, 4));
            Assert.AreNotEqual(4.5, MathLib.Mod(35.6, 5.2), Accuracy);
            Assert.AreNotEqual(123, MathLib.Mod(-2000000, 127));
            Assert.AreNotEqual(12, MathLib.Mod(12, 12));
            Assert.AreNotEqual(0.01, MathLib.Mod(10.2, 0.5), Accuracy);
        }
    }
}

