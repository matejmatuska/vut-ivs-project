using System;
using System.Collections.Generic;
using System.ComponentModel;
using MyMathLib;

namespace Calc
{
    /**
     * Enum containing supported mathematical operations
     */
    enum Operator
    {
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
     * @brief Basic math expression evaluator
     *
     * The expression to evaluate is appended to evaluator as a sequence of numbers and operators
     * The whole expression can then be evaluated and result returned
     */
    class Evaluator
    {
        private readonly List<double> numbers = new List<double>();
        private readonly List<Operator> operators = new List<Operator>();

        private bool awaitNumber = true;

        /**
         * @brief Appends number to the current expression
         * 
         * @param num The number to add to expression
         * @throw ArgumentException if num cannot be converted to double
         */
        public void Append(string num)
        {
            if (!double.TryParse(num, out var number))
            {
                if (awaitNumber)
                {
                    throw new ArgumentException("Failed to convert argument num: " + num + " to double");
                }
            }

            numbers.Add(number);
        }

        /**
         * @brief Appends operator to the current expression
         * 
         * @param op The operator to append
         */
        public void Append(Operator op)
        {
            operators.Add(op);
            awaitNumber = op != Operator.Fact;
        }
        
        /**
         * @brief Evaluates expression currently in evaluator
         *
         * Operator precedence (highest to lowest):
         * Factorial
         * Power
         * Root
         * Multiplication
         * Division
         * Modulo
         * Addition
         * Subtraction
         *
         * @note The expression is preserved and can be further appended to and/or evaluated again.
         * To clear the expression use Reset()
         * 
         * @return The result of expression currently stored in evaluator instance
         */
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
                default:
                    throw new InvalidEnumArgumentException();
            } 
        }

        /**
         * @brief Resets the evaluator to its initial state
         */
        public void Reset()
        {
            awaitNumber = true;
            operators.Clear();
            numbers.Clear();
        }
    }
}