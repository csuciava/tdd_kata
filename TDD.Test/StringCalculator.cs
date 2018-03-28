using System;

namespace TDD.Test
{
    public class StringCalculator
    {
        internal int Sum(string str)
        {
            if (str.IndexOf("\n") > 0)
            {
                str= str.Replace("\n", ",");
            }

            var arrayOfNumbers = str.Split(',');
            var result = 0;
            foreach (var strNumber in arrayOfNumbers)
            {
                var number = 0;

                if (int.TryParse(strNumber, out number))
                {
                    if (number > 0) result += number;
                }
            }

            return result;
        }
    }
}