using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResolverConsole : ActionResolver
    {
        private Message _helperMessage = new Message();
        public ActionResolverConsole()
        {
           
        }

        public override ActionResponse Execute(ActionRequest actionRequest)
        {
            var response = new ActionResponse();
            try
            {
                _helperMessage.message += $" RequestID : {actionRequest.RequestID}, RequestAction : {actionRequest.Action}, Request Input {actionRequest.Input}\n";
                switch (actionRequest.Action)
                {
                    case ActionEnum.Convert:
                        response.Output = ConvertBinary(Convert.ToDecimal(actionRequest.Input));
                        _helperMessage.message += $" RequestID : {response.ResponseID}, Request Output {response.Output}\n";
                        break;
                    case ActionEnum.Reverse:
                        response.Output = ReverseString(actionRequest.Input);
                        _helperMessage.message += $" RequestID : {response.ResponseID}, Request Output {response.Output}\n";
                        break;
                    case ActionEnum.UpperCase:
                        string[] words = actionRequest.Input.Split(' ');
                        response.Output = UpperCase(FindLongestWord(words));
                        _helperMessage.message += $" RequestID : {response.ResponseID}, Request Output {response.Output}\n";
                        break;
                    default:
                        _helperMessage.message+="Error, the num value of the INPUT is not right, please try again";
                        break;
                }

            }
            catch (Exception ex)
            {
                _helperMessage.message+=ex.ToString();
            }
            Logger.Write(_helperMessage);
            return response;
        }
       
        private string ConvertBinary(decimal number)
        {
            int i;
            int[]  binary = new int[1000];
            string result = string.Empty;
            for ( i = 0; number > 0; i++)
            {
                binary[i] =(int) number % 2;
                number = number / 2;
            }
            for (i = i - 1; i >= 0; i--)
            {
                result += binary[i];
            }
            return result;
        }

        private string UpperCase(string word)
        {
            string UpperCaseWord = string.Empty;
            UpperCaseWord = word.ToUpper();
            return UpperCaseWord;
        }

        private string FindLongestWord(string[] words)
        {
            string longest = words[0];
            for (int i = 0; i < words.Length; i++)
            {
                if (longest.Length <= words[i].Length)
                    longest = words[i];
            }
            return longest;
        }

        private string ReverseString(string myString)
        {
            string reversedString = String.Empty;

            for (int i = myString.Length - 1; i >= 0; i--)
            {
                reversedString += myString[i];

            }

            return reversedString;
        }
    }
}
