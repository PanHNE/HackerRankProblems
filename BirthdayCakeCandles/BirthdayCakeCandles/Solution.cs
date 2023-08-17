using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    public static class Solution
    {
        /*
         * Complete the 'birthdayCakeCandles' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY candles as parameter.
         */

        public static int BirthdayCakeCandles(List<int> candles)
        {
            var numberOfTheTallestCandles = 0;
            int? theTallestCandle = candles.FirstOrDefault();

            if (theTallestCandle == null) throw new Exception("Empty list of candles");

            for(int i = 0; i < candles.Count; i++){
                if (theTallestCandle == candles[i])
                {
                    numberOfTheTallestCandles++;
                } else if (theTallestCandle < candles[i])
                {
                    theTallestCandle = candles[i];
                    numberOfTheTallestCandles = 1;
                }
            }

            return numberOfTheTallestCandles;
        }
    }
}
