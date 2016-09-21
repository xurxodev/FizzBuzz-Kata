using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBizzBuzz.Code
{
    public class FizzBuzz
    {
        public static string[] GenerateOutput(int maxNumber)
        {
            String[] result = new String[maxNumber];
            for (int i = 1; i <= maxNumber; i++)
            {
                result[i - 1] = GetValue(i);
            }
            return result;
        }

        private static String GetValue(int i)
        {
            if (i % 3 == 0)
            {
                return "Fizz";
            }
            return  i.ToString();
        }
    }
}
