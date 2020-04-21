using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NrRational
{
    class Rational
    {
        private int numarator;
        private int numitor;
        
        public Rational() : this(0, 1)
        {

        }
        public Rational(int numarator) : this(numarator, 1)
        {

        }
        public Rational(int numarator, int numitor)
        {
            this.numarator = numarator;
            this.numitor = numitor;
            
        }

        public static bool operator == (Rational a, Rational b)
        {
            if (a.numarator * b.numitor == a.numitor * b.numarator)
            {
                return true;
            }

            return false;
        }

        public static bool operator != (Rational a, Rational b)
        {
            if (a.numarator * b.numitor == a.numitor * b.numarator)
            {
                return false;
            }

            return true;
        }

        public static bool operator >(Rational a, Rational b)
        {
            if (a.numarator * b.numitor > a.numitor * b.numarator)
            {
                return true;
            }

            return false;
        }

        public static bool operator <(Rational a, Rational b)
        {
            if (a.numarator * b.numitor < a.numitor * b.numarator)
            {
                return true;
            }

            return false;
        }

        public static bool operator <=(Rational a, Rational b)
        {
            if (a.numarator * b.numitor <= a.numitor * b.numarator)
            {
                return true;
            }

            return false;
        }
        public static bool operator >=(Rational a, Rational b)
        {
            if (a.numarator * b.numitor >= a.numitor * b.numarator)
            {
                return true;
            }

            return false;
        }

        public Rational Sum(Rational b)
        {
            Rational result = new Rational();
            result.numitor = numitor * b.numitor;
            result.numarator = numarator * b.numitor + b.numitor * numitor;

            return result;
        }

        public Rational Subtract(Rational b)
        {
            Rational result = new Rational();
            result.numitor = numitor * b.numitor;
            result.numarator = numarator * b.numitor - b.numarator * numitor;

            return result.Reduce();
        }

        public Rational Multiply(Rational r2)
        {
            Rational result = new Rational();

            result.numitor = numitor * r2.numitor;
            result.numarator = numarator * r2.numarator;

            return result.Reduce();
        }

        public Rational Divide(Rational r2)
        {
            return this.Multiply(r2.Inverse()).Reduce();
        }

        public Rational Power(int k)
        {
            Rational result = new Rational();

            result.numarator = (int)Math.Pow(numarator, k);
            result.numitor = (int)Math.Pow(numitor, k);

            return result.Reduce();
        }

        private Rational Inverse()
        {
            return new Rational(this.numitor, this.numarator);
        }

        public override string ToString()
        {
            return string.Format("[{0} / {1}]", numarator, numitor);
        }

        private Rational Reduce()
        {
            int d;

            d = Util.Cmmmdc(Math.Abs(numarator), Math.Abs(numitor));


            return new Rational(numarator / d, numitor / d);
        }
    }
}
