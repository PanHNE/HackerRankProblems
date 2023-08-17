using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{

    public static class Solution
    {
        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string TimeConversion(string input)
        {
            var result = DateTime.Parse(input).TimeOfDay.ToString();

            return result;
        }
    }
}
