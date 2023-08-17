using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    public static class Result
    {
        /*
         * Complete the 'compareTriplets' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            var aPoints = 0;
            var bPoints = 0;

            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] > b[i]) aPoints++;
                else if (a[i] < b[i]) bPoints++;
            }

            return new List<int> { aPoints, bPoints };
        }
    }
}
