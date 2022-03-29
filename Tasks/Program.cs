using System;
using System.IO;

namespace Tasks
{
    internal class Program
    {
        const string PATH = "A:\\Users\\ajuga\\source\\repos\\PracticaISP_20_4\\Tasks\\";
        static void Main(string[] args)
        {
            string numbers = "1,2,3,4,5,6,7,8,9,10";

            string numbersNameFile = PATH + "number.txt";
            File.WriteAllText(numbersNameFile, numbers);

            string inputString = File.ReadAllText(numbersNameFile);
            string newString = String.Empty; //inputString.Replace(',', '|');

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == ',')
                {
                    newString += '|';
                }
                else
                {
                    newString += inputString[i];
                }
            }

            string numbersSepNameFile = PATH + "numbers_sep.txt";
            File.WriteAllText(numbersSepNameFile, newString);

        }
    }
}
