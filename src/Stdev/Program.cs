using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MyMathLib;
namespace Stdev
{

    class Program
    {
        static void Main()
        {
            double x = 0.0; // initialization of arithmetic mean
            double dev = 0.0;
            double stdev = 0.0;
            double number;
            List<double> nums = new List<double>();
            int n = 0; // number of inputs
            List<string> words = new List<string>();
            //loading input numbers from stdin to nums
            string line;
            while ((line = Console.In.ReadLine()) != null)
            {
                words = line.Split(' ', '\n', '\t').ToList();
                foreach (var word in words)
                {
                    if (Double.TryParse(word, out number))
                        nums.Add(number);
                    else
                        throw new InvalidDataException("Incorrect data (not a number!).");

                }
            }

            n = nums.Count;
            if (n < 2)
            {
                throw new ArgumentException("Number of inputs must be greater than 2");
            }
            foreach (double item in nums) // Loop through List with foreach
            {
                x = MathLib.Sum(x, item);
                dev = MathLib.Sum(dev, MathLib.Pow(item, 2.0));
            }

            x = MathLib.Div(x, n); // calculation of arithmetic mean

            // counting of the standard deviation
            stdev = MathLib.Root(MathLib.Div(MathLib.Sub(dev, MathLib.Mul(n, MathLib.Pow(x, 2))), MathLib.Sub(n, 1)), 2);
            Console.WriteLine(stdev);
           // Console.ReadKey();

        }
    }
}
