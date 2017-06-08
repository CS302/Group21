using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        delegate void Operation(int a, int b);
        static object obj = new object();
        static Queue<int> queue;
        static void Main(string[] args)
        {
            #region Типы данных
            //любой тип данных на стадии компиляции
            
            //var number = 100;
            //var text = "строка";
            //Console.WriteLine(text.Length);
            ////number = "строка";
            //var x = GetNumber();

            ////любой тип на стадии выполнения
            //dynamic number1 = 100;
            //number1 += 100;
            //number1 = "строка";
            //number1 = number1 + 10;
            //Console.WriteLine(number1); 
            #endregion
            #region Процессы
            //Process[] processes = Process.GetProcesses();
            //foreach (var item in processes)
            //{
            //    if (item.ProcessName == "notepad")
            //    {
            //        item.Kill();
            //    }

            //}
            //Process.Start("chrome", "http:\\google.com");
            //ProcessStartInfo proc = new ProcessStartInfo();
            //proc.FileName = "notepad++";
            //proc.Arguments = @"C:\Users\Alex-Vaio\Desktop\VQIDVB_documents.pdf";
            //proc.WindowStyle = ProcessWindowStyle.Normal;
            //Process.Start(proc);

            //Process.Start(@"C:\Users\Alex-Vaio\Documents\GitHub\Group21\Lesson7\bin\Debug\Lesson7.exe"); 
            #endregion
            #region Делегаты
            //Operation op = new Operation(DoSmth);
            //op(10, 5);
            //op += GetNumber;
            //op += GetNumber;
            //op += GetNumber;
            //op += GetNumber;
            //op += GetNumber;
            //op += GetNumber;
            //op(5, 10);

            //Action<int, int> action = GetNumber;
            //action(10, 5);
            //
            //Func<DateTime, string> func = GetDate;
            //Console.WriteLine(func(DateTime.Now)); 
            #endregion

            //Action<int, int> action = GetNumbers;
            //action.BeginInvoke(10, 20, null, null);
            //action.BeginInvoke(-20, -10, null, null);
            ////action.EndInvoke(null);
            //while (Console.ReadLine() != "exit")
            //{   }

            queue = new Queue<int>();
            for (int i = 1; i < 100; i++)
            {
                queue.Enqueue(i);
            }
            Action<int> action = CalcQueItem;
            action.BeginInvoke(1, null, null);
            action.BeginInvoke(2, null, null);
            
            Console.ReadLine();
        }

        static void CalcQueItem(int id)
        {
            while (queue.Count != 0)
            {
                Thread.Sleep(10);
                int number = -1;
                lock (obj)
                {
                    number = queue.Dequeue();
                    number *= number;
                    Console.WriteLine("{0} - {1}", id, number);
                }
            }
        }

        static void GetNumbers(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }

        static string GetDate(DateTime date)
        {
            return date.ToLongDateString();
        }
        static void DoSmth(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void GetNumber(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
