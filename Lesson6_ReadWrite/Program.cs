using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson6_ReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string path = @"C:\Lesson6\2.txt";
            using (FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine("первая строка");
                writer.WriteLine(123456789);
                writer.WriteLine("третья строка");
                writer.Close();
            }

            //FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            //StreamReader reader = new StreamReader(stream);
            //string text = reader.ReadToEnd();
            //while (!reader.EndOfStream)
            //{
            //    Console.WriteLine(reader.ReadLine());
            //}
            //Console.WriteLine(text);

            //double x = double.Parse(reader.ReadLine());
            //double y = double.Parse(reader.ReadLine());
            //string label = reader.ReadLine();
            //stream.Close();
            
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(label);
        }
    }
}
