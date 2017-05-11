using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number1 = Sum(10, 15);
            //Console.WriteLine(number1);
            //Console.WriteLine(Sum(25, 26));

            //int number3 = Sum(Sum(10, 15), Sum(25, 26));
            //Console.WriteLine(number3);

            //ShowArrays();

            //ShowRefType();

            //string text = Console.ReadLine();
            //if (text == "exit")
            //    Console.WriteLine("Работа завершена");
            //else
            //{
            //    Console.WriteLine("Выполняется какая-то работа");
            //}
            //string text = Console.ReadLine();
            //switch (text)
            //{
            //    case "exit":
            //        Console.WriteLine("Работа завершена");
            //        break;
            //    case "option1":
            //        Console.WriteLine("Опция 1");
            //        break;
            //    case "option2":
            //    case "option3":
            //        Console.WriteLine("Опция 2");
            //        break;
            //    default:
            //        Console.WriteLine("Неверно введены данные");
            //        break;
            //}

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5)
            //        continue;
            //    Console.WriteLine(i);
            //}

            //int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string comand = Console.ReadLine();
            //while (comand != "exit")
            //{
            //    Console.WriteLine("Что-то выполняется");
            //    comand = Console.ReadLine();
            //}

            //string command;
            //do
            //{
            //    Console.WriteLine("Выполняется работа");
            //    command = Console.ReadLine();
            //} while (command != "exit");

            //foreach (var item in collection)
            //{
                
            //}

            int[,] table = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    table[i, j] = 1;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        private static void ShowRefType()
        {
            int[] array1 = new int[2] { 5, 5 };
            int[] array2 = new int[2] { 9, 9 };
            Console.WriteLine(array1[0] + " " + array1[1]);
            Console.WriteLine(array2[0] + " " + array2[1]);
            Console.WriteLine();

            array1 = array2;
            Console.WriteLine(array1[0] + " " + array1[1]);
            Console.WriteLine(array2[0] + " " + array2[1]);
            Console.WriteLine();

            array2[0] = 100;
            array2[1] = 100;
            Console.WriteLine(array1[0] + " " + array1[1]);
            Console.WriteLine(array2[0] + " " + array2[1]);
        }

        private static void ShowArrays()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.GetLength(0));

            int[,] table = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };


            Console.Write(table[0, 0] + " ");
            Console.Write(table[0, 1] + " ");
            Console.WriteLine(table[0, 2]);

            Console.Write(table[1, 0] + " ");
            Console.Write(table[1, 1] + " ");
            Console.WriteLine(table[1, 2]);

            Console.WriteLine();

            Console.WriteLine(table.Length);//общее
            Console.WriteLine(table.GetLength(0));//вертикаль
            Console.WriteLine(table.GetLength(1));//горизонталь

            int[][] arr = new int[3][];
            arr[0] = new int[3];
            arr[1] = new int[2];
            arr[2] = new int[4];

            //int[, , , ,] fiveDim = new int[1, 2, 3, 4, 5];
        }



        static int Sum(int a, int b)
        {
            return a + b;

        }


    }
}
