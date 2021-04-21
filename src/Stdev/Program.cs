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
            double arithmAvg = 0.0;
            double deviation = 0.0;
            double s = 0.0;
            List<int> nums = new List<int>();
            int n = 0;
            string[] words = new string[1000];
            //loading input numbers from stdin to nums
            string line;
            while ((line = Console.In.ReadLine()) != null)
            {
                words = line.Split(' ', '\n', '\t');
                foreach (var word in words)
                {
                    nums.Add(Int32.Parse(word));
                }
            }

            n = nums.Count;
            foreach (int item in nums) // Loop through List with foreach
            {
                arithmAvg = MathLib.Sum(arithmAvg, item);
                deviation = MathLib.Sum(deviation, MathLib.Pow(item, 2.0));
            }

            arithmAvg = MathLib.Div(arithmAvg, n);

            // counting of the standard deviation
            s = MathLib.Root(MathLib.Div(MathLib.Sub(deviation, MathLib.Mul(n, MathLib.Pow(arithmAvg, 2))), MathLib.Sub(n, 1)), 2);
            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
