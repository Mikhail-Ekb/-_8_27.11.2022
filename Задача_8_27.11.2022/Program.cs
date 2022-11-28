using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8_Работа_над_ошибками
{
    private static void Main(string[] args)
    {
        string path = @"C:\Temp\Numbers.txt";
        Random random = new Random();
        using (StreamWriter sw = new StreamWriter(path, false))
        {
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(random.Next());
            }
        }

        int sum = 0;
        using (StreamReader sr = new StreamReader(path))
        {
            for (int i = 0; i < 10; i++)
            {
                sum += Convert.ToInt32(sr.ReadLine());
            }
        }
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}
