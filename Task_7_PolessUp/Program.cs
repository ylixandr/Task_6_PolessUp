﻿using System;

namespace ConsoleApp
{
    class Program
    {
        static void ConvertDoubleToWord(double num)
        {
            string numStr = num.ToString();
            int numLength = numStr.Length;
            string numWord = "";

            for (int i = 0; i < numLength; i++)
            {
                switch (numStr[i])
                {
                    case '-':
                        numWord += "minus ";
                        break;
                    case ',':
                        numWord += "point ";
                        break;
                    case '1':
                        numWord += "one ";
                        break;
                    case '2':
                        numWord += "two ";
                        break;
                    case '3':
                        numWord += "three ";
                        break;
                    case '4':
                        numWord += "four ";
                        break;
                    case '5':
                        numWord += "five ";
                        break;
                    case '6':
                        numWord += "six ";
                        break;
                    case '7':
                        numWord += "seven ";
                        break;
                    case '8':
                        numWord += "eight ";
                        break;
                    case '9':
                        numWord += "nine ";
                        break;
                    case '0':
                        numWord += "zero ";
                        break;
                }
            }
            Console.WriteLine(numWord);
        }
        static void Main(string[] args)
        {
            double num = 25.8;
            ConvertDoubleToWord(num);
        }
    }
}