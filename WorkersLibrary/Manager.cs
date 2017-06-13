using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersLibrary
{
    public class Manager : Worker, IPayTax
    {
        private int projCount;

        public int ProjCount
        {
            get { return projCount; }
            set { projCount = value; }
        }

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
}
