using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.Goods
{
    public class Book : Good
    {
        public override string Print()
        {
            return String.Format("Книга:\n{0}", base.Print());
        }

        public Book(string name, double weight)
            : base(name, weight)
        {   }
    }
}
