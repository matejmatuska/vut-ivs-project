using System;

namespace MyMathLib
{


    public static class MathLib
    {
        /*
         * sums 2 double numbers together
         *
         *@param    input1,input2     numbers that you want to sum
         *@return   the result of the sum in double
         */
        public static double Sum(double input1, double input2)
        {
            return input1 + input2;
        }

        /*
         * subtracts 2 double numbers
         *
         *@param    input1,input2     numbers that you want to subtract
         *@return   the result of the subtraction in double
         */
        public static double Sub(double input1, double input2)
        {
            return input1 - input2;
        }

        /*
         * multiplies 2 double numbers
         *
         *@param    input1,input2     numbers that you want to multiply
         *@return   the result of the multiplication in double
         */
        public static double Mul(double input1, double input2)
        {
            return input1 * input2;
        }

        /*
         * divides 2 double numbers
         *
         *@param    input1,input2     numbers that you want to divide
         *@return   the result of the multiplication in double
         *          exception when dividing by 0
         */
        public static double Div(double input1, double input2)
        {
            //dividing by 0 check
            if (input2 == 0)
                throw new DivideByZeroException();

            return input1 / input2;
        }

        /*
         * calculates factorial of double number
         *
         *@param    input1     the number to calculate the factorial from
         *@return   the factorial in double
         *          exception when the number is less than 0
         *          exception when the number is decimal
         */
        public static double Fact(double input1)
        {
            //negative number check
            if (input1 < 0)
                throw new ArgumentOutOfRangeException();

            //decimal number check
            if ((input1 - Math.Truncate(input1)) != 0)
                throw new ArgumentOutOfRangeException();

            //factorial of zero is 1
            if (input1 == 0)
                return 1;

            //calculation of the factorial
            double result = input1;
            for (int i = 1; i < input1-1; i++)
            {
                result *= (input1 - i);
            }
            
            return result;
        }

        /*
         * calculates natural power of real number
         *
         *@param    input1      base number
         *@param    input2      exponent
         *@return   input1 raised to the input2
         *          exception when the exponent is less than 0
         *          exception when the base number and exponent are 0
         *          exeption when the exponent is decimal number
         */
        public static double Pow(double input1, double input2)
        {
            //negative power check
            if (input2 < 0)
                throw new ArgumentOutOfRangeException();

            //zero power of the zero check
            if ((input1 == 0) && (input2 == 0))
                throw new InvalidOperationException();

            //decimal number check
            if ((input2 - Math.Truncate(input2)) != 0)
                throw new ArgumentOutOfRangeException();

            //zero power of any number is always equal to 1
            if (input2 == 0)
                return 1;

            //calculation of the power
            double result = input1;
            for (int i = 1; i < input2; i++)
            {
                result *= input1;
            }

            return result;
        }

        /*
         * calculates n-th root of the real number
         *
         *@param    input1      base number
         *@param    input2      root
         *@return   the root in input2 of the number in input1
         *          exception when the root is 0
         *          exception when the root is even and base number is a negative number
         */
        public static double Root(double input1, double input2)
        {
            //zero base number check
            if ((input2 == 0) && (input1 != 0))
                throw new DivideByZeroException();

            //even base number and negative number check
            if (((input2 % 2) == 0) && input1 < 0) 
                throw new InvalidOperationException();
            
            //zero root of zero is equal to zero
            if ((input1 == 0) && (input2 == 0))
                return 0;

            //calculation of the root
            return (double)Math.Pow(input1, 1.0 / input2);
        }

        /*
         * calculates the discriminant of the equation with a, b, c coefficients
         *
         *@param    a,b,c   coefficients      
         *@return   discriminant
         */
        public static double Disc(double a, double b, double c)
        {
            //calculation of the discriminant
            return (b * b) - (4 * a * c);
        }
    }
}
