using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = @"C:\Temp";
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (string file in files)
                Console.WriteLine(file);
            Console.ReadLine();
        }
    }
}
