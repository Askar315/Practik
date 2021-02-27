using System;
using System.IO;

namespace Practika_1_3
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
                    Console.WriteLine("X:" + text.Substring(0, text.IndexOf(',')) + " Y:" + text.Substring(text.IndexOf(',')));

                }

            }
            //Закрытие файла
            Practika_2.Close();

            string Yes = "0";
            string NO = "1";

            Console.WriteLine("Вы хотите ввести свои координаты 0 - да, 1 - нет");
            string x = Console.ReadLine();

            if (Yes == x)
            {
                Console.WriteLine("Введите свои 3 координаты:");
                string q = Console.ReadLine();
                string w = Console.ReadLine();
                string e = Console.ReadLine();

                Console.WriteLine("Отформатированном вид:");

                Console.WriteLine("X:" + q.Substring(0, q.IndexOf(",")) + " Y:" + q.Substring(q.IndexOf(",")));
                Console.WriteLine("X:" + w.Substring(0, w.IndexOf(",")) + " Y:" + w.Substring(w.IndexOf(",")));
                Console.WriteLine("X:" + e.Substring(0, e.IndexOf(",")) + " Y:" + e.Substring(e.IndexOf(",")));
            }
            else if (NO == x)
            {
                Console.WriteLine("Отказ прощайте!!!");
                return;
            }


        }
    }
}
