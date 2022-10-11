using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_A1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string CheckPrimeNumber(string input)
        {
            int checkPrimeNumber = 0;
            int convertInput = 0;
            string result = "";

            convertInput = int.Parse(input);
            for (int i = 1; i <= convertInput; i++)
            {
                if (convertInput % i == 0)
                {
                    checkPrimeNumber += 1;
                }
            }
            if (checkPrimeNumber == 2) { result = "Prime Number"; }
            else { result = "Not Prime Number"; }

            return result;
        }

        public string CalculateSumOfDigits(string input)
        {
            char[] charArrayInput = input.ToCharArray();
            string[] sumOfValue = new string[charArrayInput.Length];
            int result = 0;
            string finalResult = "";

            for (int i = 0; i < charArrayInput.Length; i++)
            {
                sumOfValue[i] = charArrayInput[i].ToString();
            }
            for (int i = 0; i < sumOfValue.Length; i++)
            {
                result += int.Parse(sumOfValue[i]);
            }

            return finalResult = result.ToString();
        }

        public string ReverseString(string input)
        {
            string result = "";

            char[] charArrayInput = input.ToCharArray();
            for (int i = charArrayInput.Length - 1; i >= 0; i--)
            {
                result += charArrayInput[i].ToString();
            }
            return result;
        }

        public string PrintHTMLTag(string inputTag, string inputData)
        {
            string result = $"<{inputTag}>{inputData}</{inputTag}>";
            return result;
        }

        public string SortNumbers(string choiceNumber, string input)
        {
            string inputValue = "";
            string output = "";
            string finalResult = "";
            int result = 0;
            int convertIntChoiceNumber = 0;


            char[] charArrayInput = input.ToCharArray();
            int[] arrInput = new int[charArrayInput.Length];

            convertIntChoiceNumber = int.Parse(choiceNumber);

            for (int i = 0; i < charArrayInput.Length; i++)
            {
                inputValue = charArrayInput[i].ToString();
                result = int.Parse(inputValue);
                arrInput[i] = result;
            }

            if (convertIntChoiceNumber == 1)
            {
                for (int i = 0; i < arrInput.Length; i++)
                {
                    for (int j = 0; j < arrInput.Length - 1; j++)
                    {
                        if (arrInput[j] > arrInput[j + 1])
                        {
                            int resultTwo = arrInput[j];
                            arrInput[j] = arrInput[j + 1];
                            arrInput[j + 1] = resultTwo;
                        }
                    }
                }

                Console.Write("Ascending Sort : ");
                for (int k = 0; k < arrInput.Length; k++)
                {
                    //Console.Write(arrInput[k] + " ");
                    output += arrInput[k].ToString() + " ";


                }
                finalResult = $"Ascending Sort: {output}";
            }
            if (convertIntChoiceNumber == 2)
            {
                for (int i = 0; i < arrInput.Length; i++)
                {
                    for (int j = 0; j < arrInput.Length - 1; j++)
                    {
                        if (arrInput[j] < arrInput[j + 1])
                        {
                            int resultTwo = arrInput[j];
                            arrInput[j] = arrInput[j + 1];
                            arrInput[j + 1] = resultTwo;
                        }
                    }
                }

                Console.Write("Descending Sort : ");
                for (int k = 0; k < arrInput.Length; k++)
                {
                    //Console.Write(arrInput[k] + " ");
                    output += arrInput[k].ToString() + " ";
                }
                finalResult = $"Descending Sort: {output}";
            }
            return finalResult;
        }

    }
}
