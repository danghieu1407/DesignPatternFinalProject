using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.BuilderPattern
{
     interface IMingsu
    {
        MingsuBuilder addVi(String vi);
        MingsuBuilder addSize(String size);
        MingsuBuilder addSua(String sua);
        Mingsu Build();
    }
}
