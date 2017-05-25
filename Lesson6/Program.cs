using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region RefOut
            ////int a = 100;
            ////int b = 200;
            ////Switch(ref a, ref b);
            ////Console.WriteLine("a = {0}", a);
            ////Console.WriteLine("b = {0}", b);
            //int number;
            //bool flag = int.TryParse(Console.ReadLine(), out number);
            //if (flag)
            //    Console.WriteLine(number * number);
            //else
            //{
            //    Console.WriteLine("Ошибка ввода");
            //    Console.WriteLine(number);
            //}
            #endregion

            //string[] files = Directory.GetFiles(@"C:\Lesson6", "*", SearchOption.AllDirectories);
            //for (int i = 0; i < files.Length; i++)
            //{
            //    Console.WriteLine(files[i]);
            //    Console.WriteLine(File.GetCreationTime(files[i]));
            //}

            //DirectoryInfo dir = new DirectoryInfo(@"C:\Lesson6");
            //if (dir.Exists == true)
            //{
            //    FileInfo[] files = dir.GetFiles("*", SearchOption.AllDirectories);
            //    for (int i = 0; i < files.Length; i++)
            //    {
            //        Console.WriteLine(files[i].FullName);
            //        Console.WriteLine(files[i].CreationTime);
            //        Console.WriteLine(files[i].Length);
            //    }
            //}

            FileInfo file1 = new FileInfo(@"C:\Lesson6\1.txt");
            file1.Create();

            file1 = new FileInfo(@"C:\Lesson6\Test\1.txt");
            if (file1.Directory.Exists == false)
                file1.Directory.Create();
            file1.Create();

            Directory.CreateDirectory(@"C:\Lesson6\Test\1\2\3\4\5\6\7\8\9");

            string dir = @"C:\Lesson6\Test";
            string temp = "temp24";
            string file = "data.txt";
            string path = dir + "\\" + temp + "\\" + file;

            path = Path.Combine(dir, temp, file);
            Directory.CreateDirectory(@"Lesson6\Test\1\2\3");
            
        }

        static void Switch(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
