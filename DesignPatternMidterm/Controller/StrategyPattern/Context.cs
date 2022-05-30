using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.StrategyPattern
{
	public class Context
	{
		private Payment payment;

		public Context() { }
		public void setPayment(Payment strategy)
		{
			this.payment = strategy;
		}
		public Payment getPayment()
		{
			return payment;
		}
		public String methodPay(String n)
		{
			return payment.methodPay(n);

		}
		public double pay(double a, double b)
		{
			return payment.pay(a, b);
		}
	}
}
