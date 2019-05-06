using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReverStringIITest();

            //ReverStringIIITest();

            ReverWordsITest();
        }

        private static void ReverWordsITest()
        {
            var tests = new List<string>()
            {
                //"  hello world!",
                "a good    example",
                "a b c",
                "the sky is blue"
            };

            var test = new ReverseWordsI151();
            foreach (var str in tests)
            {
                Console.WriteLine("Origin: {0} After: {1}", str, test.ReverseWords(str));
            }
        }

        private static void ReverStringIIITest()
        {
            var s = "Let's take LeetCode contest";
            var test = new ReverseWordsIII557();
            Console.WriteLine(test.ReverseWords(s));
        }

        private static void ReverStringIITest()
        {
            string s = "hyzqyljrnigxvdtneasepfahmtyhlohwxmkqcdfehybknvdmfrfvtbsovjbdhevlfxpdaovjgunjqlimjkfnqcqnajmebeddqsgl";
            var k = 39;

            ReverseStringII541 test = new ReverseStringII541();
            Console.WriteLine(test.ReverseStr(s, k));
        }
    }
}
