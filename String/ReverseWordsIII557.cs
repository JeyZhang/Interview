using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class ReverseWordsIII557
    {
        public string ReverseWords(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return s;
            }

            var chars = s.ToCharArray();

            var begin = 0;
            var end = begin + 1;

            while (true)
            {
                while (end < chars.Length && chars[end] != ' ')
                {
                    end++;
                }

                if (end == chars.Length)
                {
                    ReverseChars(chars, begin, end - 1);
                    break;
                }

                if (end - begin > 1)
                {
                    ReverseChars(chars, begin, end - 1);
                }

                end++;
                begin = end;
            }

            return new string(chars);
        }

        private void ReverseChars(char[] chars, int begin, int end)
        {
            while (begin < end)
            {
                var tmp = chars[begin];
                chars[begin] = chars[end];
                chars[end] = tmp;

                ++begin;
                --end;
            }
        }
    }
}
