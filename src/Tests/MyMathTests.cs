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
            Assert.AreEqual(350000000, math.Sum(175000000, 175000000));
            Assert.AreEqual(-182.52697, math.Sum(-3, -179.52697), Accuracy);
            Assert.AreEqual(-300000, math.Sum(-400000, 100000));
            //false
            Assert.AreNotEqual(352, math.Sum(0, 8));
            Assert.AreNotEqual(-20, math.Sum(-5, -3));
            Assert.AreNotEqual(1.22000, math.Sum(0.60000, 0.60000), Accuracy);
            Assert.AreNotEqual(0, math.Sum(0, 1));
            Assert.AreNotEqual(250000000, math.Sum(10000000, 15000000));
            Assert.AreNotEqual(-512.25252, math.Sum(312.25252, -200));
            Assert.AreNotEqual(0, math.Sum(-0.1, 0.11), Accuracy);
            Assert.AreNotEqual(10, math.Sum(30, 20));
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
            Assert.AreEqual(1880002536, math.Sub(1880002694, 158));
            Assert.AreEqual(300, math.Sub(-150, -450));
            Assert.AreEqual(2.99999, math.Sub(3, 0.00001), Accuracy);
            //false
            Assert.AreNotEqual(352, math.Sub(0, 8));
            Assert.AreNotEqual(-20, math.Sub(-5, -3));
            Assert.AreNotEqual(0.0001, math.Sub(0.60000, 0.60000), Accuracy);
            Assert.AreNotEqual(0, math.Sub(0, 1));
            Assert.AreNotEqual(200000000, math.Sub(300000000, 1));
            Assert.AreNotEqual(2.99999, math.Sub(3, 0.1111111), Accuracy);
            Assert.AreNotEqual(-145, math.Sub(-14, 5));
            Assert.AreNotEqual(1, math.Sub(0, 0));

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
            Assert.AreEqual(-1.91265738124716e10, math.Mul(-125.2569, 152698764),Accuracy);
            Assert.AreEqual(2.56984, math.Mul(1.25, 2.055872), Accuracy);
            Assert.AreEqual(30, math.Mul(300, 0.100));
            //false
            Assert.AreNotEqual(0, math.Mul(-50, 2));
            Assert.AreNotEqual(-9, math.Mul(-3, -3));
            Assert.AreNotEqual(3.00000, math.Mul(1.20000, 2), Accuracy);
            Assert.AreNotEqual(-2, math.Mul(0, 0));
            Assert.AreNotEqual(15000000, math.Mul(27500, 2));
            Assert.AreNotEqual(14.01, math.Mul(7, 2), Accuracy);
            Assert.AreNotEqual(-1, math.Mul(0, 0));
            Assert.AreNotEqual(-154.2569, math.Mul(-12458.236, 2546.269),Accuracy);

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
            Assert.AreEqual(300000000, math.Div(30, 0.0000001),Accuracy);
            Assert.AreEqual(0, math.Div(0, 5));
            Assert.AreEqual(3.230383522, math.Div(10.52698, 3.25874),Accuracy);  
            Assert.AreEqual(62.5, math.Div(-125, -2), Accuracy);

            //false
            Assert.AreNotEqual(0, math.Div(-50, 2));
            Assert.AreNotEqual(-9, math.Div(-3, -3));
            Assert.AreNotEqual(0.06000, math.Div(1.20000, 2), Accuracy);
            Assert.AreNotEqual(-2, math.Mul(10, 10));
            Assert.AreNotEqual(3.234383522, math.Div(10.52698, 3.25784), Accuracy);
            Assert.AreNotEqual(1, math.Div(1, 5));
            Assert.AreNotEqual(15.41677, math.Div(185, 12), Accuracy);
            Assert.AreNotEqual(15000000, math.Div(15000000000, 1));
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
            Assert.AreEqual(1, math.Fact(1));
            Assert.AreEqual(6, math.Fact(3));
            Assert.AreEqual(362880, math.Fact(9));
            Assert.AreEqual(2.432902008e18, math.Fact(20), Accuracy);
            Assert.AreEqual(1, math.Fact(0));
            Assert.AreEqual(2, math.Fact(2));
            Assert.AreEqual(24, math.Fact(4));
            Assert.AreEqual(120, math.Fact(5));
            //false
            Assert.AreNotEqual(5, math.Fact(5));
            Assert.AreNotEqual(1, math.Fact(1));
            Assert.AreNotEqual(32, math.Fact(64));
            Assert.AreNotEqual(0, math.Fact(0));
            Assert.AreNotEqual(3628800, math.Fact(9));
            Assert.AreNotEqual(8.71783e10, math.Fact(14), Accuracy);
            Assert.AreNotEqual(-120, math.Fact(5));
            Assert.AreNotEqual(5, math.Fact(5));

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
            try
            {
                math.Pow(0, 0);
            }
            catch (InvalidOperationException)
            {

            }
            //are equal
            Assert.AreEqual(1, math.Pow(54, 0));
            Assert.AreEqual(1, math.Pow(1, 84));
            Assert.AreEqual(27, math.Pow(3, 3));
            Assert.AreEqual(-16, math.Pow(-4, 2));
            Assert.AreEqual(140.608, math.Pow(5.2, 3), Accuracy);
            Assert.AreEqual(6.979147079e42, math.Pow(240, 18),Accuracy);
            Assert.AreEqual(643.586161, math.Pow(25.369, 2), Accuracy);
            Assert.AreEqual(-1.060449937, math.Pow(-13, 9), Accuracy);
            //false
            Assert.AreNotEqual(0, math.Pow(2, 0));
            Assert.AreNotEqual(20, math.Pow(1, 20));
            Assert.AreNotEqual(9, math.Pow(3, 3));
            Assert.AreNotEqual(16, math.Pow(-4, 2));
            Assert.AreNotEqual(140.61, math.Pow(5.2, 3), Accuracy);
            Assert.AreNotEqual(-42, math.Pow(42,1));
            Assert.AreNotEqual(4.12549e38, math.Pow(132, 5), Accuracy);
            Assert.AreNotEqual(-300, math.Pow(-14.42, 3));
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
            catch (InvalidOperationException)
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
            Assert.AreEqual(0.1111111, math.Root(81,-2), Accuracy);
            Assert.AreEqual(13, math.Root(62748517, 7));
            Assert.AreEqual(0.25, math.Root(0.0625, 2), Accuracy);


            //not equal
            Assert.AreNotEqual(3, math.Root(8, 2));
            Assert.AreNotEqual(-5, math.Root(0, 5));
            Assert.AreNotEqual(3.85243, math.Root(14, 2), Accuracy);
            Assert.AreNotEqual(3.33333, math.Root(10, 3), Accuracy);
            Assert.AreNotEqual(1, math.Root(2, 2), Accuracy);
            Assert.AreNotEqual(1.02135, math.Root(81, 81), Accuracy);
            Assert.AreNotEqual(-2, math.Root(4, 2));
            Assert.AreNotEqual(-1.2569, math.Root(-6.254, 7), Accuracy);

        }
     
        [TestMethod]
        // test discriminant function
        public void DiscTest()
        {
            Mymathclass math = new Mymathclass();
            //are equal
            Assert.AreEqual(76, math.Disc(3, 4, -5));
            Assert.AreEqual(638.44, math.Disc(0.8, 25, -4.2), Accuracy);
            Assert.AreEqual(0, math.Disc(0, 0, 0));
            Assert.AreEqual(0, math.Disc(2, 4, 2));
            Assert.AreEqual(-3, math.Disc(1, 1, 1));
            Assert.AreEqual(15999952000000, math.Disc(12000000, 4000000, 1));
            Assert.AreEqual(-4.534824, math.Disc(0.1254, 0.324, 9.25), Accuracy);
            Assert.AreEqual(1472, math.Disc(-14, -32, 8), Accuracy);
            //are not equal
            Assert.AreNotEqual(-812.5, math.Disc(5, 2, 5),Accuracy);
            Assert.AreNotEqual(-20, math.Disc(352, 2, 5.8), Accuracy);
            Assert.AreNotEqual(1, math.Disc(1, 1, 1));
            Assert.AreNotEqual(8, math.Disc(-8, 0, -80));
            Assert.AreNotEqual(-3.5, math.Disc(25, 18, 1), Accuracy);
            Assert.AreNotEqual(638.4, math.Disc(0.8, 25, -4.2), Accuracy);
            Assert.AreNotEqual(-1511376, math.Disc(-90000, 25, -4.2));
            Assert.AreNotEqual(0, math.Disc(1, 1, 0));
        }
    }
}

