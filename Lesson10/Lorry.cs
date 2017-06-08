using Lesson10.Goods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public class Lorry : List<Good>
    {
        private double maxWeight;
        private double weight;
        private Guid id;
        //public List<Good> items; 

        //индексатор
        //public Good this[int i]
        //{
        //    get { return items[i]; }
        //}

        public Guid Id
        {
            get { return id; }
        }

        public Lorry(double maxWeight)
        {
            this.maxWeight = maxWeight;
            this.id = Guid.NewGuid();
            //items = new List<Good>();
        }

        public bool Add(Good good)
        {
            if (weight + good.Weight <= maxWeight)
            {
                good.Id = this.id;
                base.Add(good);
                weight += good.Weight;
                return true;
            }
            else
                return false;
        }

        public bool RemoveAt(int number)
        {
            if ((number >= 0) && (number < base.Count))
            {
                weight -= base[number].Weight;
                base.RemoveAt(number);
                return true;
            }
            else
                return false;
        }
    }
}
