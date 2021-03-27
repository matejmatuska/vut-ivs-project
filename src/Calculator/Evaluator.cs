using System;

using MyMathLib;

namespace Calc
{
    /**
     * Enum containing supported mathematical operations, as well as special value "None" 
     */
    enum Operator
    {
        None, Sum, Sub, Mul, Div, Fact, Pow, Root, Disc
    }
    
    /**
     * Basic math evaluator
     *
     * Numbers and operations are passed in as a sequence.
     * Intermediate results are returned via callback.
     *
     * Due to the sequential nature of this class parentheses are not supported
     */
    class Evaluator
    {

        private bool inProgress = false;
        private double result = 0; // stores intermediate results
        private Operator currOp = Operator.None;

        /**
         * Append number num to the current calculation
         * 
         * @param num The number to add to calculation, as string
         * @throw Exception if num cannot be converted to number
         * @throw Exception when two numbers were entered consecutively and num is not first number in the calculation
         * @return returns intermediate result as string
         */
        public string Append(string num)
        {
            double number;

            if (!double.TryParse(num, out number))
            {
                throw new Exception("Invalid number!"); //TODO handle invalid number
            }

            if (!inProgress)
            {
                result = number;
                return num;
            }

            switch (currOp)
            {
                case Operator.Mul:
                    result = MathLib.Mul(result, number);
                    break;
                case Operator.Sum:
                    result = MathLib.Sum(result, number);
                    break;
                case Operator.Sub:
                    result = MathLib.Sub(result, number);
                    break;
                case Operator.Div:
                    result = MathLib.Div(result, number);
                    break;
                case Operator.Fact:
                    result = MathLib.Fact(result);
                    break;
                case Operator.Pow:
                    result = MathLib.Pow(result, number);
                    break;
                case Operator.Root:
                    result = MathLib.Root(result, number);
                    break;
                case Operator.Disc:
                    // TODO
                    //result = mathLib.Disc(result, number);
                    break;
                case Operator.None:
                    throw new Exception("Two numbers without operator entered!"); // TODO handle two numbers without operator entered
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            inProgress = false;
            currOp = Operator.None;
            return result.ToString();
        }

        /**
         * Appends operator to the current calculation,
         * Operator.None can be entered to delete previously set operator.
         * 
         * @param op The operation to append
         * @throws ArithmeticException if more than one operator is passed consecutively
         */
        public void Append(Operator op)
        {
            if (currOp != Operator.None)
            {
                // reset the state
                result = 0;
                inProgress = false;
                currOp = Operator.None;
                throw new ArithmeticException("Multiple operators!"); // TODO handle multiple operators
            }
            currOp = op;
            inProgress = true;
        }
 
        /**
         * Resets the evaluator to its initial state
         */
        public void Reset()
        {
            inProgress = false;
            result = 0;
            currOp = Operator.None;
        }
        
    }
    
}
