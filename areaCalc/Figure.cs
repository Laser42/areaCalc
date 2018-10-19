using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaCalc
{
    public abstract class Figure {

        public string Name { get; set; }

        public double Area { get; protected set; }

        public double Perimeter { get; protected set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
