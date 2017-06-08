using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkersLibrary;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<Worker> list = new List<Worker>();
            list.Add(new Driver("John", 29, 123456, "BMW", 128));
            list.Add(new Manager("Bob", 39, 789456, 10));
            list.Add(new Manager("Hulk", 59, 321789, 7));
            list.Add(new Driver("Henry", 32, 654123, "Audi", 256));
            list.Add(new Manager("Sara", 35, 987321, 5));
            //list[0].Print();
            
            //foreach (Worker item in list)
            //{
            //    item.Print();
            //}
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("программировать", 4);
            dict.Add("бегать", 3);
            
            if (dict.ContainsKey("программировать"))
            {
                dict["программировать"] += 1;
            }

            //foreach (KeyValuePair<string, int> item in dict)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            Stack<int> stack = new Stack<int>(); //LIFO
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            //Console.WriteLine(stack.Pop());  //удаляет
            //Console.WriteLine(stack.Peek()); //не удаляет

            //foreach (int item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Количество = {0}", stack.Count);

            //while (stack.Count != 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            //Console.WriteLine("Количество = {0}", stack.Count);

            Queue<int> queue = new Queue<int>(); //FIFO
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            Console.WriteLine(queue.Dequeue());*/

            //Point<int, double> p = new Point<int, double>(1, 1000000);
            //p.Print();

            Point<string, double> p1 = new Point<string, double>("John", 500000);
            p1.Print();

            Point<Worker, double> p2 = new Point<Worker, double>(new Driver("John", 29, 123456, "BMW", 128), 600000);
            p2.Print();

            Console.ReadLine();
            
        }
    }
}
