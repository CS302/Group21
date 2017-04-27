using System;

namespace Group21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Наша первая программа
            Console.WriteLine("Hello World!");
            
            int number = 10;
            Console.WriteLine(number);
            number = 100;
            Console.WriteLine(number);

            //int number2 = 15;
            number = (6453 + 78) * 98;
            number = 10 - number;
            Console.WriteLine(number);
            Console.WriteLine();
            number = 56 / 10;
            Console.WriteLine(number);
            number = 56 % 10;
            Console.WriteLine(number);
            int num1 = 56;
            int num2 = 10;
            
            double price = (double)num1 / num2;
            Console.WriteLine(price);

            string text = "7894";
            

            //text = Console.ReadLine();

            number = int.Parse(text);
            number = number + 10;
            Console.WriteLine(number);
            Console.WriteLine();

            char symbol = 'A';
            Console.WriteLine("a" + "b" + "c");
            Console.WriteLine('a' + 'b' + 'c');//97+98+99
            Console.WriteLine((int)'0');

            bool flag = true;
            Console.WriteLine(flag && false);
            //flag = !flag;
            Console.WriteLine(flag);
            float fnum = 10.98745f;
            decimal bignum = 10.897m;

            number = 5;

            number--;
            number += 10;
            Console.WriteLine(number);

            int day = 27;
            int month = 4;
            int year = 2017;
            int hour = 19;
            int minute = 56;

            DateTime date = new DateTime(2017, 4, 27, 19, 56, 0);
            Console.WriteLine(date.DayOfWeek);
            
            Console.ForegroundColor = ConsoleColor.Yellow;

            Users user = Users.Guest;
            Console.WriteLine((int)user);
            if (user == Users.Guest)
            {
                Console.WriteLine("Hello, guest!");
            }
            
            Console.WriteLine("Goodbye, world!" + number);
        }
    }
    enum Users
    {
        Admin,
        Guest,
        RegUser,
        Banned
    }
}
