using System;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {

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
            return Principal * Math.Pow((1 + (InterestRate / TimesCompounded)), (TimesCompounded * Years));
        }
    }
}
