using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class Strstr
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (!string.IsNullOrEmpty(haystack) && haystack.Length >= needle.Length)
            {
                for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
                {
                    var isMatch = true;

                    for (int j = 0; j < needle.Length; j++)
                    {
                        if (haystack[i + j] != needle[j])
                        {
                            isMatch = false;
                            break;
                        }
                    }

                    if (isMatch)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
