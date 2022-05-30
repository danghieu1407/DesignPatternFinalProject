using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.BuilderPattern
{
     class MingsuBuilder : IMingsu
    {
        public String vi { get; set; }
        public String size { get; set; }
        public String sua { get; set; }

        public MingsuBuilder addVi(String vi)
        {
            this.vi = vi;
            return this;
        }

        public MingsuBuilder addSize(String size)
        {
            this.size = size;
            return this;
        }

        public MingsuBuilder addSua(String sua)
        {
            this.sua = sua;
            return this;
        }
        public Mingsu Build()
        {
            return new Mingsu(vi, size, sua);
        }
    }
}
