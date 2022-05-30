using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.StrategyPattern
{
    public class Momo : Payment
    {
        public String methodPay(String n)
        {
            return "Momo";
        }
        public Double pay(double a, double b)
        {
            return b - a;
        }
    }
}
