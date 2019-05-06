using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class ReverseWordsI151
    {
        public string ReverseWords(string s)
        {
            var sb = new StringBuilder();

            int end = s.Length;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    end = i;
                }
                else if (i == 0 || s[i - 1] == ' ')
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(" ");
                    }

                    sb.Append(s.Substring(i, end - i));
                }
            }

            return sb.ToString();
        }

        /*
        public string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            var chars = s.ToCharArray();

            // remove the starting and ending blanks
            int begin = 0, end = chars.Length - 1;

            while (begin < chars.Length && chars[begin] == ' ')
            {
                ++begin;
            }

            while (end >= 0 && chars[end] == ' ')
            {
                --end;
            }

            if (begin >= end)
            {
                return string.Empty;
            }

            // reverse the chars
            int[] copy = new int[] { begin, end };

            while (begin < end)
            {
                var tmp = chars[begin];
                chars[begin] = chars[end];
                chars[end] = tmp;

                ++begin;
                --end;
            }

            // reverse splits
            begin = copy[0];
            end = begin + 1;
            var boundary = copy[1];

            while (true)
            {
                while (end <= boundary && chars[end] != ' ')
                {
                    ++end;
                }

                if (end > boundary)
                {
                    ReverseChars(chars, begin, end - 1);
                    while (begin <= boundary && chars[begin] != ' ')
                    {
                        begin++;
                    }

                    break;
                }

                ReverseChars(chars, begin, end - 1);
                ++end;

                while (begin < end && chars[begin] != ' ')
                {
                    ++begin;
                }

                ++begin;

                if (end <= boundary && chars[end] == ' ')
                {
                    while (end <= boundary && chars[end] == ' ')
                    {
                        ++end;
                    }
                }
            }

            var res = "";
            for (int i = copy[0]; i < begin; i++)
            {
                res += chars[i];
            }

            return res;
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
        */
    }
}
