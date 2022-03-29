using System;
using System.Collections.Generic;
using System.IO;

namespace Task2
{
    internal class Program
    {
        const string PATH = "A:\\Users\\ajuga\\source\\repos\\PracticaISP_20_4\\Task2\\students.dat";
        static void Main(string[] args)
        {
            string[] students = File.ReadAllLines(PATH);
            List<string> outList = new List<string>();

            int summ = 0;
            for (int i = 0; i < students.Length; i++)
            {
                summ += getGrade(students[i]);
            }

            double average = summ / students.Length;

            for (int i = 0; i < students.Length; i++)
            {
                if (getGrade(students[i]) > average)
                {
                    outList.Add(students[i]);
                }
            }

            File.WriteAllLines(PATH, outList);

            Console.WriteLine();
        }
        static int getGrade(string inputString)
        {
            string[] splitedString = inputString.Split('\t');
            int grade = 0;
            //if (splitedString[1] != "нб")
            //{
            //    grade = int.Parse(splitedString[1]);
            //}

            try
            {
                grade = int.Parse(splitedString[1]);
            }
            catch (Exception)
            {
                grade = 0;
            }

            return grade;
        }
    }
}
