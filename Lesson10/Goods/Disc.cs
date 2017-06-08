using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.Goods
{
    public class Disc : Good
    {
        public override string Print()
        {
            return String.Format("Диск:\n{0}", base.Print());
        }

        public Disc(string name, double weight)
            : base(name, weight)
        {   }
    }
}
