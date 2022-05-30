using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.StrategyPattern
{
    public interface Payment
    {
        public String methodPay(String n);
        public Double pay(double a, double b);
    }
}
