using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.Goods
{
    public abstract class Good
    {
        private double weight;
        private string name;
        private Guid id;

        public double Weight
        {
            get { return weight; }
        }
        public Guid Id
        {
            set { id = value; }
            get { return id; }
        }

        public virtual string Print()
        {
            return String.Format("Название: {0}, Масса = {1}", name, weight);
        }
        public Good(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }
    }
}
