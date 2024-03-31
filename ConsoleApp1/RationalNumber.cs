using RatioAbstract;

namespace RationalNumber.Rational
{
    class RationalNumber : RationalNumberAbstract
    {
        public int Numerator;
        public int Denominator;

        public RationalNumber(int numerator, int denominator)
        {
            //Занменатель != 0
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator must be  != 0");
            }
            //Приведение знаков
            if (denominator < 0 & numerator < 0)
            {

                numerator *= -1;
                denominator *= -1;
            }
            else
            {
                if ((numerator < 0) || (denominator < 0))
                {
                    Numerator = -Math.Abs(numerator);
                    Denominator = Math.Abs(denominator);
                    return;
                }
            }

            Numerator = numerator;
            Denominator = denominator;
            Reduse();

        }

        public override int GCD(int numerator, int denominator)
        {
            while (denominator != 0)
            {
                int t = denominator;
                denominator = numerator % denominator;
                numerator = t;
            }
            return numerator;
        }

        public override void Reduse()
        {
            int a = GCD(Numerator, Denominator);
            Numerator /= a;
            Denominator /= a;
        }

        public override string ToString()
        {
            // Сокращение и перевод в int
            if (Numerator % Denominator == 0)
            {
                return $"{Numerator / Denominator}";
            }
            if (Numerator == 0)
            {
                return "0";
            }
            return $"{Numerator}/{Denominator}";
        }

        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber((a.Numerator * b.Denominator) + (b.Numerator * a.Denominator), a.Denominator * b.Denominator);
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber((a.Numerator * b.Denominator) - (b.Numerator * a.Denominator), a.Denominator * b.Denominator);
        }

        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber((a.Numerator) * (b.Numerator), a.Denominator * b.Denominator);
        }

        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber((a.Numerator) * (b.Denominator), a.Denominator * b.Numerator);
        }

        public static RationalNumber operator -(RationalNumber a)
        {
            return new RationalNumber(-a.Numerator, a.Denominator);
        }

        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            if (a.Numerator * b.Denominator == b.Numerator * a.Denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            if (a.Numerator * b.Denominator != b.Numerator * a.Denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            if (a.Numerator * b.Denominator >= b.Numerator * a.Denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            if (a.Numerator * b.Denominator <= b.Numerator * a.Denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            if (a.Numerator * b.Denominator > b.Numerator * a.Denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            if (a.Numerator * b.Denominator < b.Numerator * a.Denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
