using System;
using Xunit;
using FizzBuzzLib;

namespace FizzBuzzTests
{
    public class FizzBuzzTestSuite
    {
		[Fact]
        public void Principal0Amount0 () {
            FizzBuzz fb = new FizzBuzz();
            double actual = fb.getCompoundInterest(0, 1, 3, 5);
            double expected = 0;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenNegativeTimeThrowException()
        {
            FizzBuzz fb = new FizzBuzz();
            Exception ex = Assert.Throws<Exception>(
                () => fb.getCompoundInterest(0, 1, 3, -1)
            );
            string expected = "Time cannot be less than 0";
            string actual = ex.Message;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideByZeroExceptionInterestRate()
        {
            FizzBuzz fb = new FizzBuzz();
            Exception ex = Assert.Throws<System.DivideByZeroException>(
                () => fb.getCompoundInterest(0, 0, 3, 0)
            );
            string expected = "Attempted to divide by zero.";
            string actual = ex.Message;
            Assert.Equal(expected, actual);

        }

		[Fact]
		public void NegativeInterestRateException()
		{
			FizzBuzz fb = new FizzBuzz();
			Exception ex = Assert.Throws<Exception>(
				() => fb.getCompoundInterest(0, -1, 3, 5)
            );
			string expected = "Interest Rate cannot be less than 0";
			string actual = ex.Message;
			Assert.Equal(expected, actual);
		}

        [Fact]
        public void Principal5000Amount10()
        {
            FizzBuzz fb = new FizzBuzz();
            double actual = fb.getCompoundInterest(5000, 0.05, 12, 10);
            double expected = 8235.0474884514;
			Assert.Equal(expected, actual);
        }

        [Fact]
        public void NegativePrincipalException()
        {
            FizzBuzz fb = new FizzBuzz();
            Exception ex = Assert.Throws<Exception>(
                () => fb.getCompoundInterest(-100, 8, 3, 8)
            );
            string expected = "Principal cannot be less than 0";
            string actual = ex.Message;
            Assert.Equal(expected, actual);
        }


    }
}
