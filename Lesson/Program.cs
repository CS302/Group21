using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
//            string text = "простой текст";
//            string text2 = "";
//            text2 = string.Empty;
//            Console.WriteLine(text[0]);
//            Console.WriteLine(text.Length);
//            Console.WriteLine(text[text.Length - 1]);
//            Console.WriteLine("-------------");
//            text = "\a";
//            Console.WriteLine(text);
//            text = "первая\r123";
//            Console.WriteLine(text);
//            text = "|";
//            Console.WriteLine();
            
//            string[] symbols = new string[]{"\\", "|", "/", "-"};
//            //for (int i = 0; i < 1000; i++)
//            //{
//            //    Console.Write(symbols[i % 4] + "\r");
//            //    Thread.Sleep(200);
//            //}
//            string path = @"C:\Lesson6\1.txt";
//            //path = Console.ReadLine();
//            Console.WriteLine("наши занятия \"легкие\"");
//            char symbol = '\'';
//            text = @"первая
//            вторая 
//                            третья";
//            Console.WriteLine(text);
            
//            Console.WriteLine("---------------");

//            text = "простая строка";
//            Console.WriteLine(text.Contains("стр"));
//            Console.WriteLine(text.Insert(0, "Это "));
//            //text = text.Insert(0, "Это ");
//            Console.WriteLine(text.Remove(8, 3));

//            Console.WriteLine(text.Replace('о', 'а'));
//            Console.WriteLine(text.Replace("простая", "сложная"));

//            Console.WriteLine(text.ToLower());
//            text = " login ";
//            Console.WriteLine("|" + text.TrimEnd(' ')+ "|");
            
//            string data = "345 879 321 8 9 65 79";
//            string[] items = data.Split(' ');
//            int sum = 0;
//            for (int i = 0; i < items.Length; i++)
//            {
//                sum += int.Parse(items[i]);
//            }
//            Console.WriteLine(sum);

            //int n = 1000000;
            //StringBuilder data = new StringBuilder();
            //Console.WriteLine(data.Capacity);
            //for (int i = 0; i < n; i++)
            //{
            //    data.Append(i);
            //}
            //Console.WriteLine(data.Length);
            //Console.WriteLine(data.MaxCapacity);

            //double x = 123.456;
            //double y = 789.654;
            //Console.WriteLine("X = {0}\nY = {1}", x, y);

            //string text = string.Format("X = {0}\nY = {1}", x, y);
            //Console.WriteLine(text);

            //double price = 99.9999;
            //Console.WriteLine("{0}", price);
            //Console.WriteLine("{0:e}", price);//science
            
            //Console.WriteLine("{0:c}", price);//commercial
            //DateTime date = new DateTime();
            //date = DateTime.Now;
            //Console.WriteLine("{0:hh.mm}", date);
            //Console.WriteLine("{0:yyyy.MMM.dd HH:mm}", date);

            Point p = new Point(123.4568155, 789.6546431);
            Console.WriteLine("{0:e}", p);
            Console.WriteLine("{0:csv}", p);

            double price = 45.9999;
            Console.WriteLine("{0:.00}", price);
        }
    }

    class Point : IFormattable
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format)
            {
                case "e":
                    return string.Format("{0:e} {1:e}", x, y);
                case "csv":
                    return string.Format("{0};{1}", x, y);
                default:
                    return ToString();
            }
        }
    }
}
