using System;
using System.IO;
using System.Text;
using COnverter;

namespace Laba4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tom = new COnverter.Convert();
            var path = @"D:\SomeDir3";
            var dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists) dirInfo.Create();
            string b = "", a, flag = "0";

            using (var fstream = new FileStream($@"{path}\note.txt", FileMode.OpenOrCreate))
            {
                // считываем первый символ
                var output = new byte[1];
                fstream.Read(output, 0, 1);
                // декодируем байты в строку
                flag = Encoding.Default.GetString(output);
                output = new byte[fstream.Length - 1];
                fstream.Read(output, 0, output.Length);
                // декодируем байты в строку
                a = Encoding.Default.GetString(output);
                Console.WriteLine($"Текст из файла: {a}"); // hello house
            }

            switch (flag)
            {
                case "1":
                    b = COnverter.Convert.FromN(a, "16");
                    break;

                case "2":

                    b = COnverter.Convert.FromN(a,"8");
                    break;

                case "3":
                    b = COnverter.Convert.FromN(a, "3");
                    break;

                case "4":
                    b = COnverter.Convert.FromN(a, "2");
                    break;
            }

            if (b != "")
            {
            }


            try
            {
                if (args[0] == "-NoWindow")
                {
                    Console.WriteLine("Полученное значение: " + b);
                    Console.Read();
                }
            }
            catch (Exception)
            {
            }

            using (var fstream = new FileStream($"{path}\\result.txt", FileMode.Create))
            {
                var array = Encoding.Default.GetBytes(b);
                // асинхронная запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
        }
    }
}