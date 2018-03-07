using System;

namespace TDD.Test
{
    public class StringCalculator
    {
        internal int Sum(string str)
        {
            var arrayOfNumbers = str.Split(',');
            var result = 0;
            foreach (var strNumber in arrayOfNumbers)
            {
                var number = 0;
                if (int.TryParse(strNumber, out number))
                    result += number;
            }

            return result;
        }
    }
}