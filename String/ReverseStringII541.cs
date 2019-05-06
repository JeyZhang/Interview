using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class ReverseStringII541
    {
        public string ReverseStr(string s, int k)
        {
            if (string.IsNullOrEmpty(s) || k <= 1)
            {
                return s;
            }

            var chars = s.ToCharArray();
            int begin = 0;

            while (begin < s.Length)
            {
                ReverseChars(chars, begin, k);

                begin += 2 * k;
            }

            return new string(chars);
        }

        private void ReverseChars(char[] chars, int begin, int k)
        {
            var end = begin + k - 1;
            if (end >= chars.Length)
            {
                end = chars.Length - 1;
            }

            while (begin < end)
            {
                var tmp = chars[begin];
                chars[begin] = chars[end];
                chars[end] = tmp;

                begin++;
                end--;
            }
        }
    }
}
