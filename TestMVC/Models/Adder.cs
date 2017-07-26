using System;
namespace TestMVC.Models
{
    public class Adder
	{
        private decimal internalSum = 0;

        public Adder()
        {
        }

        public Adder Add(int i){
            internalSum += i;
            return this;
		}

		public Adder Add(long l)
		{
			internalSum += l;
			return this;
		}

		public Adder Add(double i)
		{
			internalSum += Convert.ToDecimal(i);
			return this;
		}

		public Adder Add(decimal i)
		{
			internalSum += i;
			return this;
		}

        public decimal GetSum() {
            return internalSum;
        }

        //public Adder Add(object o){
        //    throw new NotImplementedException("the parameter was not a number type");
        //}
    }
}
