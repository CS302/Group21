using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[3];
            workers[0] = new Worker("John", 29, 123456);
            workers[1] = new Worker("Bob", 39, 789456);
            workers[2] = new Worker("Hulk", 59);
            
            Console.WriteLine(workers[0].Age);

            Console.WriteLine();

            Worker.PrintWorkers(workers);

            Console.WriteLine(Worker.count);
        }
    }

    class Worker
    {
        private string name;    //поле
        private int age;        //поле
        public int snn;        //поле
        
        public static int count;
        
        public string Name
        {
            get { return name; }
        }
        public int Age          //свойство
        {
            set
            {
                if ((value >= 14) && (value < 65))
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Неверно задан возраст!");
                }
            }
            get 
            {
                return age;
            }
        }

        public void SetAge(int a)
        {
            if ((a >= 14) && (a < 65))
            {
                age = a;
            }
            else
            {
                Console.WriteLine("Возраст задан неверно!");
            }
        }
        public int GetAge()
        {
            return age;
        }
        public void Print()     //метод
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("ИНН: " + snn);
            Console.WriteLine();
        }

        public static void PrintWorkers(Worker[] workers)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].Print();
            }
        }


        /// <summary>
        /// Параметризованный базовый конструктор
        /// </summary>
        /// <param name="name">Имя работника</param>
        /// <param name="age">Возраст работника</param>
        /// <param name="snn">ИНН работника</param>
        public Worker(string name, int age, int snn)
        {
            this.name = name;
            Age = age;
            this.snn = snn;
            count++;
        }

        public Worker(string name, int age)
            : this(name, age, 0)
        {   }

        static Worker()
        {
            count = 0;
        }
    }
}
