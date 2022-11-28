using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = @"C:\Temp\Slovenia.txt";
            int charCount = 0;
            int wordCount = 0;
            int lineCount = 1;

            using (StreamReader sr = new StreamReader(path))
            {
                string str = sr.ReadToEnd();
                charCount = str.Length;

                foreach (char c in str)
                {
                    if (c == ' ')
                    {
                        wordCount++;
                    }
                    else
                    {
                        if (c == '\n')
                        {
                            lineCount++;
                        }
                    }
                }
                Console.WriteLine($"Количество символов: {charCount}\nКоличество слов: {wordCount}\nКоличество строк: {lineCount}.");
                Console.ReadLine();
            }
        }
    }
}
