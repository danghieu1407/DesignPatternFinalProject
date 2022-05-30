using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.BuilderPattern
{
     class Mingsu
    {
        public String vi;
        public String size;
        public String sua;

        public Mingsu(String vi, String size, String sua)
        {
            this.vi = vi;
            this.size = size;
            this.sua = sua;
        }

        public override string ToString()
        {
            return "Mingsu vị " + vi + ", size " + size + ", sữa " + sua;
        }
    }
}
