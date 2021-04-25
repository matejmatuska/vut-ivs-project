using System;
using System.Collections.Generic;
using MyMathLib;

namespace Calc
{
    /**
     * Enum containing supported mathematical operations, as well as special value "None" 
     */
    enum Operator
    {
        None,
        Sum,
        Sub,
        Mul,
        Div,
        Fact,
        Pow,
        Root,
        Mod
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
        private List<double> numbers = new List<double>();
        private List<Operator> operators = new List<Operator>();

        private bool awaitNumber = true;

        /**
         * Append number num to the current calculation
         * 
         * @param num The number to add to calculation, as string
         * @throw Exception if num cannot be converted to number
         * @throw Exception when two numbers were entered consecutively without an operator between them
         * @return returns intermediate result as string
         */
        public void Append(string num)
        {
            if (!double.TryParse(num, out var number))
            {
                if (awaitNumber)
                {
                    throw new Exception("Invalid number!"); //TODO handle invalid number
                }
            }

            numbers.Add(number);
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
            operators.Add(op);
            awaitNumber = op != Operator.Fact;
        }
        
        public double Eval()
        {
            var precedence = new List<Operator>
            {
                Operator.Fact, 
                Operator.Pow, 
                Operator.Root, 
                Operator.Mul, 
                Operator.Div, 
                Operator.Mod, 
                Operator.Sum, 
                Operator.Sub
            };

            foreach (var pop in precedence)
            {
                for (var i = 1; i <= operators.Count; i++)
                {
                    var op = operators[i - 1];

                    if (op != pop)
                        continue; // only eval the precedent operator

                    var a = numbers[i - 1];
                    double b;

                    b = numbers[i];

                    var res = GetResult(op, a, b);

                    numbers.Remove(a);
                    numbers.Remove(b);
                    numbers.Insert(i - 1, res);
                    
                    operators.Remove(op);
                    i--;
                }
            }
            return numbers[0];
        }

        private static double GetResult(Operator op, double a, double b)
        {
            switch (op)
            {
                case Operator.Mul:
                    return MathLib.Mul(a, b);
                case Operator.Sum:
                    return MathLib.Sum(a, b);
                case Operator.Sub:
                    return MathLib.Sub(a, b);
                case Operator.Div:
                    return MathLib.Div(a, b);
                case Operator.Fact:
                    return MathLib.Fact(a);
                case Operator.Pow:
                    return MathLib.Pow(a, b);
                case Operator.Root:
                    return MathLib.Root(b, a);
                case Operator.Mod:
                    return MathLib.Mod(a, b);
                case Operator.None:
                    throw new Exception(
                        "Two numbers without operator entered!"); // TODO handle two numbers without operator entered
                default:
                    throw new ArgumentOutOfRangeException();
            } 
        }

        /**
         * Resets the evaluator to its initial state
         */
        public void Reset()
        {
            awaitNumber = true;
            operators.Clear();
            numbers.Clear();
        }
    }
}