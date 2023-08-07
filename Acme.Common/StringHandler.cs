using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {
        // Adds spaces before capital letters in strings
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        // Remove any existing spaces
                        result = result.Trim();
                        result += " ";

                    }
                  
                    result += letter;
                }

            }
            // Remove space from beginning of string
            result = result.Trim();
            return result;
        }
    }
}
