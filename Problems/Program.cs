using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyFourGame679Test();

        }

        private static void TwentyFourGame679Test()
        {
            var test = new TwentyFourGame679();
            var inputs = new int[] { 3, 4, 6, 7 };
            Console.WriteLine(test.JudgePoint24(inputs));
        }
    }
}
