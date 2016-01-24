using System;
using System.Numerics;

namespace _02.Fraction_Calculator
{
    struct Fraction
    {
        private long numerator;
        private long denumerator;

        public Fraction(long numerator, long denumerator)
            : this()
        {
            long greatestCommonDivisor = GetGreatestCommonDivisor(numerator, denumerator);
            if (greatestCommonDivisor > 1)
            {
                numerator /= greatestCommonDivisor;
                denumerator /= greatestCommonDivisor;
            }

            this.Numerator = numerator;
            this.Denumerator = denumerator;
        }

        public long Numerator
        {
            get { return this.numerator; }

            set { this.numerator = value; }
        }

        public long Denumerator
        {
            get
            {
                return this.denumerator;
            }

            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Denumerator of a rational number cannot be zero.");
                }

                this.denumerator = value;
            }
        }

        public double Value
        {
            get
            {
                double value = (double)this.Numerator / this.Denumerator;
                return value;
            }
        }

        public static Fraction operator +(Fraction fractionA, Fraction fractionB)
        {
            BigInteger resultNumerator = ((BigInteger)fractionA.Numerator * fractionB.Denumerator) +
                                         ((BigInteger)fractionA.Denumerator * fractionB.Numerator);

            BigInteger resultDenominator = (BigInteger)fractionA.Denumerator * fractionB.Denumerator;

            BigInteger gcd = GetGreatestCommonDivisor(resultNumerator, resultDenominator);

            if (gcd > 1)
            {
                resultNumerator /= gcd;
                resultDenominator /= gcd;
            }

            if (resultNumerator < long.MinValue || long.MaxValue < resultNumerator)
            {
                throw new ArithmeticException("Numeratoris too large or too small.");
            }

            if (resultDenominator > long.MaxValue)
            {
                throw new ArithmeticException("Denominator is too large.");
            }

            return new Fraction((long)resultNumerator, (long)resultDenominator);
        }

        public static Fraction operator -(Fraction fractionA, Fraction fractionB)
        {
            Fraction result = fractionA + new Fraction(fractionB.Numerator * -1, fractionB.Denumerator);
            return result;
        }

        public string SimpleFractionToString()
        {
            return string.Format("{0}/{1}", this.Numerator, this.Denumerator);
        }

        public override string ToString()
        {
            return string.Format("{0}", (decimal)this.Numerator / this.Denumerator);
        }

        private static long GetGreatestCommonDivisor(BigInteger numerator, BigInteger denominator)
        {
            while (denominator != 0)
            {
                BigInteger tempDenominator = denominator;
                denominator = numerator % denominator;
                numerator = tempDenominator;
            }

            return (long)numerator;
        }
    }
}
