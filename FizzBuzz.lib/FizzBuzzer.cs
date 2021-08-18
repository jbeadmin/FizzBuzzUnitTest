using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.lib
{
    public class FizzBuzzer
    {
        public string GetValue(int number)
        {
            string output = string.Empty;
            
            if (number % 3 == 0)
                output += "Fizz";           
            if (number % 5 == 0)
                output += "Buzz";
            if(String.IsNullOrEmpty(output))
                output = number.ToString();
            return output;
        }
    }
}
