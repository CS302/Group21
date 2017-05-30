using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Point<T, M> where T:class
    {
        public T x;
        public M y;

        public Point(T x, M y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine("Месяц {0}\nЗарплата {1}", x, y);
        }
    }

    class SPoint
    {
        public string x;
        public double y;

        public SPoint(string x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine("Работник {0}\nЗарплата {1}", x, y);
        }
    }
}
