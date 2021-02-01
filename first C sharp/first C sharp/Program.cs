using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_C_sharp
{
    class Program
    {
        /*переменную объявлять тут для доступа всех функций к ней*/
        Random rnd;
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Beep(); /*звук бибика*/
            int a = rnd.Next(1, 50);
            Console.WriteLine(a); /*всегда надо переменные переводить в текст или цифру*/
            string text = "";
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    text = "one"; break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    text = "один"; break;
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                    text = "два"; break;
                case 31:
                case 32:
                case 33:
                case 34:
                case 35:
                case 36:
                case 37:
                case 38:
                case 39:
                case 40:
                    text = "три"; break;
                case 41:
                case 42:
                case 43:
                case 44:
                case 45:
                case 46:
                case 47:
                case 48:
                case 49:
                case 50:
                    text = "четыре"; break;
                default: text = "Ошибка"; // как else в питоне//
                    break;
            }
            Console.WriteLine(text);
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Choose Backspace");
                nupp = Console.ReadKey();
            } while (nupp.Key != ConsoleKey.Backspace);

            if (a >= 1 && a <= 10)
            { text = "111111111"; }

            else if (a >= 11 && a <= 20)
            { text = "22222222"; }

            else if (a >= 21 && a <= 30)
            { text = "3333333333"; }

            else if (a >= 31 && a <= 40)
            { text = "44444444"; }

            else if (a >= 41 && a <= 50)
            { text = "555555555"; }
            Console.WriteLine(text);

            StreamWriter file = new StreamWriter(@"..\..\text.txt", true);//true здесь добавляется для дозаписи//
            file.WriteLine(text);
            file.Close();
            StreamReader filest = new StreamReader(@"..\..\text.txt", true);
            text = filest.ReadToEnd();
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Yellow;//
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Text in the file: \n{0}", text);

            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            for (int j=0;j<numbers.Length;j++)
            {
                Console.WriteLine(numbers[j]);
            }

            Random r = new Random();
            int[] numbers2 = new int[6];
            for (int k=0;k<numbers2.Length;k++)
            {
                numbers2[k] = r.Next(1, 200);
            }
            foreach (int i in numbers2)
            {
                Console.WriteLine(i);
            }

            int[,] numbers3 = new int [4,10];
            for (int i = 0; i < numbers3.GetLength(0); i++)
            {
                for (int j = 0; j < numbers3.GetLength(1); j++)
                {
                    numbers3[i, j] = 1;
                }
            }
            for (int i = 0; i < numbers3.GetLength(0); i++)
            {
                for (int j = 0; j < numbers3.GetLength(1); j++)
                {
                    Console.Write(numbers3[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
