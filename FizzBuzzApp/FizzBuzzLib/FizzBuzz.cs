using System;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
		public string GetFizzBuzz(int number)
		{
			string result = string.Empty;

			if (number == 0)
				throw new Exception("Zero is not allowed.");

			if (number > 100)
				throw new Exception("Number cannot be greater than 100.");

			for (int i = 1; i <= number; i++) {
				if (i%3 == 0 && i%5==0) {
					result += "fizzbuzz ";
				} else if (i % 3 == 0) {
					result += "fizz ";
				} else if (i % 5 == 0) {
					result += "buzz ";
				} else {
					result += i.ToString() + " ";
				}
			}

			return result;
		}

        public double getCompoundInterest(double Principal, double InterestRate, double TimesCompounded, double Years)
        {
            if (Years < 0)
            {
                throw new Exception("Time cannot be less than 0");
            }

            if (InterestRate == 0)
            {
                throw new DivideByZeroException();
            }

            if (InterestRate < 0)
            {
                throw new Exception("Interest Rate cannot be less than 0");
            }

            if (Principal < 0)
            {
                throw new Exception("Principal cannot be less than 0");
            }
            return Principal * Math.Pow((1 + (InterestRate / InterestRate)), (TimesCompounded * Years));
        }
    }
}
