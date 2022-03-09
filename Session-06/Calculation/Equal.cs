using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class Equal
    {
        private string _operators;
        public Equal()
        {
            _operators = string.Empty;
        }
       
        public double ExecutEqual(double[] numbers)
        {
            Operators tmpOperators;
            string[] Op=ConvertStringToOperators();
            //double result;
            for (int i = 0; i < Op.Length; i++)
            {
                switch (Op[i])
                {
                    case "+":
                        tmpOperators = new Add();
                        numbers[i +1] = tmpOperators.ExecuteOperators(numbers[i], numbers[i + 1]);
                        break;
                    case "*":
                        tmpOperators = new Multiplication();
                        numbers[i + 1] = tmpOperators.ExecuteOperators(numbers[i], numbers[i + 1]);
                        break;
                    case "/":
                        tmpOperators = new Division();
                        numbers[i + 1] = tmpOperators.ExecuteOperators(numbers[i], numbers[i + 1]);
                        break;
                    case "-":
                        tmpOperators = new Subtraction();
                        numbers[i + 1] = tmpOperators.ExecuteOperators(numbers[i], numbers[i + 1]);
                        break;
                    case "^":
                        tmpOperators = new Power();
                        numbers[i + 1] = tmpOperators.ExecuteOperators(numbers[i], numbers[i + 1]);
                        break;
                    case "√":
                        tmpOperators = new Root();
                        numbers[numbers.Length - 1] = tmpOperators.ExecuteOperators(numbers[i],0);
                        break; 
                }
                
            }
            return numbers[numbers.Length-1];
        }

        public double[] ConvertStringToNumbers(string mystring)
        {
            string tmpstring = FindNumbers(mystring);

            string[] splitString = tmpstring.Split(' ');

            return StringArrayToDecimalArray(splitString);
        }

        private string FindNumbers(string mystring)
        {
            string result = string.Empty;
            for (int i = 0; i < mystring.Length; i++)
            {
                if (Char.IsDigit(mystring[i]) || mystring[i] == '.')
                    result += mystring[i];
                else
                {
                    _operators += $"{mystring[i]} ";
                    result += " ";
                   
                }
            }
            return result;
        }

        private double[] StringArrayToDecimalArray(string[] mystrings)
        {
            
          double[] result = new double[mystrings.Length];
          for (int i = 0; i < mystrings.Length; i++)
          {
                double.TryParse(mystrings[i],out result[i]);
          }
          return result;
        }

        private string[] ConvertStringToOperators()
        {
            string[] splitString = _operators.Split(' ');
            return splitString;
        }

    }
}
