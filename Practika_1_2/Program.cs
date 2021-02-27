using System;
using System.IO;

namespace Practika_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            //Считывание текста с папки
            StreamReader Practika_2 = new StreamReader("coordinates.txt");


            Console.WriteLine("Your marked coordinates on the map:");
            while (text != null)
            {
                //Читаем файловый докумет и присваиваем в text
                text = Practika_2.ReadLine();
                if (text != null)
                {
                    // вывод отформатированном вида
                    Console.WriteLine("X:" + text.Substring(0, text.IndexOf(',')) + " Y:" + text.Substring(text.IndexOf(',')) + 1, text.Length - text.IndexOf(','));

                }

            }
            //Закрытие файла
            Practika_2.Close();
        }
    }
}
