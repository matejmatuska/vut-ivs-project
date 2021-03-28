using System;

namespace MyMathLib
{


    public static class MathLib
    {
        public static double Sum(double input1, double input2)
        {
            return input1 + input2;

        }

        public static double Sub(double input1, double input2)
        {
            return input1 - input2;

        }

        public static double Mul(double input1, double input2)
        {
            return input1 * input2;

        }

        public static double Div(double input1, double input2)
        {
            if (input2 == 0)
                throw new DivideByZeroException();

            return input1 / input2;

        }

        public static double Fact(double input1)
        {
            if (input1 < 0)
                throw new ArgumentOutOfRangeException();

            if (((double)input1 - Math.Truncate(input1)) != 0)
                throw new ArgumentOutOfRangeException();

            if (input1 == 0)
                return 1;

            double result = input1;
            for (int i = 1; i < input1; i++)
            {
                result *= (input1 - i);
            }
            
            return result;
        }

        public static double Pow(double input1, double input2)
        {
            if (input2 < 0)
                throw new ArgumentOutOfRangeException();

            if ((input1 == 0) && (input2 == 0))
                throw new InvalidOperationException();

            if (input2 == 0)
                return 1;

            double result = input1;
            for (int i = 1; i < input2; i++)
            {
                result *= input1;
            }

            return result;
        }
            public static double Root(double input1, double input2)
        {
                if ((input2 == 0) && (input1 != 0))
                    throw new DivideByZeroException();

                if (((input2 % 2) == 0) && input1 < 0)
                    throw new InvalidOperationException();

                if ((input1 == 0) && (input2 == 0))
                    return 0;

                return (double)Math.Pow(input1, 1.0 / input2);
        }

        public static double Disc(double a, double b, double c)
        {
                return (b * b) - (4 * a * c);
            }
    }
}
