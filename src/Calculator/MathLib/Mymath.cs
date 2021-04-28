﻿using System;

namespace MyMathLib
{


    public static class MathLib
    {
        /**
          @brief sums 2 double numbers together
         
          @param    x1, x2     numbers that you want to sum
          @return   the result of the sum in double
         */
        public static double Sum(double x1, double x2)
        {
            return x1 + x2;
        }

        /**
          @brief subtracts 2 double numbers
         
          @param    x1, x2     numbers that you want to subtract
          @return   the result of the subtraction in double
         */
        public static double Sub(double x1, double x2)
        {
            return x1 - x2;
        }

        /**
          @brief multiplies 2 double numbers
         
          @param    x1, x2     numbers that you want to multiply
          @return   the result of the multiplication in double
         */
        public static double Mul(double x1, double x2)
        {
            return x1 * x2;
        }

        /**
          @brief divides 2 double numbers
         
          @param    x1, x2     numbers that you want to divide
          @return   the result of the multiplication in double
                    exception when dividing by 0
         */
        public static double Div(double x1, double x2)
        {
            //dividing by 0 check
            if (x2 == 0)
                throw new DivideByZeroException("Division by zero is undefined");

            return x1 / x2;
        }

        /**
          @brief calculates factorial of double number
         
          @param    x     the number to calculate the factorial from
          @return   the factorial in double
                    exception when the number is less than 0
                    exception when the number is decimal
         */
        public static double Fact(double x)
        {
            //negative number check
            if (x < 0)
                throw new InvalidOperationException("Factorial is only defined on non-negative integers");

            //decimal number check
            if ((x - Math.Truncate(x)) != 0)
                throw new InvalidOperationException("Factorial can be only full number");

            //factorial of zero is 1
            if (x == 0)
                return 1;

            //calculation of the factorial
            double result = x;
            for (int i = 1; i < x-1; i++)
            {
                result *= (x - i);
            }
            
            return result;
        }

        /**
          @brief calculates natural power of real number
          
          @param    x      base number
          @param    n      exponent
          @return   x raised to the n
                    exception when the exponent is less than 0
                    exception when the base number and exponent are 0
                    exeption when the exponent is decimal number
         */
        public static double Pow(double x, double n)
        {
            //negative power check
            if (n < 0)
                throw new InvalidOperationException("Power can be only non-negative number");

            //zero power of the zero check
            if ((x == 0) && (n == 0))
                throw new InvalidOperationException("Vague expression");

            //decimal power check
            if ((n - Math.Truncate(n)) != 0)
                throw new InvalidOperationException("Power can be only full number");

            //zero power of any number is always equal to 1
            if (n == 0)
                return 1;

            //calculation of the power
            double result = x;
            for (int i = 1; i < n; i++)
            {
                result *= x;
            }

            return result;
        }

        /**
          @brief calculates n-th root of the real number
          
          @param    x      base number
          @param    n      root
          @return   the x-th root of the number n
                    exception when the root is 0
                    exception when the root is even and base number is a negative number
         */
        public static double Root(double x, double n)
        {
            //zero base number check
            if ((n == 0) && (x != 0))
                throw new InvalidOperationException("The root can be zero only if the base is zero");

            //even base number and negative number check
            if (((n % 2) == 0) && x < 0) 
                throw new InvalidOperationException("The base can be negative only if the root is odd");
            
            //zero root of zero is equal to zero
            if ((x == 0) && (n == 0))
                return 0;

            //calculation of the root with negative base
            if(x < 0)
            {
                x *= -1;
                return -(double)Math.Pow(x, 1.0 / n);
            }

            //calculation of the root with non-negative base
            return (double)Math.Pow(x, 1.0 / n);
        }


        /**
         @brief calculates the modulo of two numbers 
         
         @param    x1   dividend
         @param    x2   divisor       
         @return   the ramainder of x1 / x2
                   exception when the x2 is equal to 0
        */
        public static double Mod(double x1, double x2)
        {
            //dividing by zero check
            if (x2 == 0)
            {
                throw new DivideByZeroException("Division by zero is undefined");
            }

            //calculates the remainder
            double mod = x1 - Math.Truncate(x1 / x2)*x2;

            return mod;
        }
    }
}
