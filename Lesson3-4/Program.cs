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
            Worker[] workers = new Worker[5];
            workers[0] = new Driver("John", 29, 123456, "BMW", 128);
            workers[1] = new Manager("Bob", 39, 789456, 10);
            workers[2] = new Manager("Hulk", 59, 321789, 7);
            workers[3] = new Driver("Henry", 32, 654123, "Audi", 256);
            workers[4] = new Manager("Sara", 35, 987321, 5);
            
            //for (int i = 0; i < workers.Length; i++)
            //{
            //    workers[i].Print();
            //    Console.WriteLine();
            //}

            Driver driver = new Driver("Henry", 32, 654123, "Audi", 256);
            Worker worker = driver;
            Console.WriteLine(worker.Age);

            Driver dr = (Driver)worker;
            Console.WriteLine(dr.hours);
            Console.WriteLine();

            Manager manager = new Manager("Bob", 39, 789456, 10);
            worker = manager;
            dr = worker as Driver;
            if (dr != null)
            {
                Console.WriteLine(dr.hours);
            }

            Random rnd = new Random();
            rnd.Next(1, 11);
        }
    }

    abstract class Worker
    {
        private string name;    //поле
        private int age;        //поле
        public int snn;        //поле
        protected int salary;

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
        public virtual void Print()     //метод
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("ИНН: " + snn);
            
        }

        public abstract int GetBonus();

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
            salary = 35000;
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

    sealed class Driver : Worker
    {
        public string carType;
        public int hours;

        public Driver(string name, int age, int snn, string carType, int hours)
            : base(name, age, snn)
        {
            this.carType = carType;
            this.hours = hours;
            salary = 45000;
        }

        public override int GetBonus()
        {
            return hours * 50;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Машина: " + carType);
            Console.WriteLine("Часы: " + hours);
            Console.WriteLine();
        }
    }

    class Manager : Worker, IPayTax 
    {
        public int projCount;

        public Manager(string name, int age, int snn, int projCount)
            : base(name, age, snn)
        {
            this.projCount = projCount;
            salary = 50000;
        }

        public override int GetBonus()
        {
            return projCount * 1500;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Кол-во проектов: " + projCount);
            Console.WriteLine();
        }

        public double PayTax()
        {
            return 0.13 * salary;
        }
    }

    interface IPayTax
    {
        double PayTax();
    }

    //class SuperMan : Driver, Manager
    //{ }

    //class SuperDriver : Driver
    //{ }
}
