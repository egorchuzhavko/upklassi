using System;
using System.Collections.Generic;
using System.Text;

namespace obwee
{
    class Complex
    {
        public double r, i;
        public Complex() { }
        public Complex(double r, double i)
        {
            this.r = r;
            this.i = i;
        }

        public Complex Sum(Complex b) { return new Complex(r + b.r, i + b.i); }
        public Complex Razn(Complex b) { return new Complex(r - b.r, i - b.i); }
        public Complex Multi(Complex b) { return new Complex(r * b.r - i * b.i, r * b.r + i * b.i); }
        public Complex Div(Complex b) { return new Complex(((r * b.r) + (i * b.i)) / ((b.r * b.r) + (b.i * b.i)), 
            ((b.r * i) - (r * b.i)) / ((b.r * b.r) + (b.i * b.i))); }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex()
            {
                i = a.i + b.i,
                r = a.r + b.r
            };
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex()
            {
                i = a.i - b.i,
                r = a.r - b.r
            };
        }

        public static Complex operator +(Complex a, double k)
        {
            return new Complex()
            {
                i = a.i,
                r = a.r + k
            };
        }

        public static Complex operator -(Complex a, double k)
        {
            return new Complex()
            {
                i = a.i,
                r = a.r - k
            };
        }

        public bool Equals(Complex n)
        {
            if ((object)n == null)
            {
                return false;
            }

            return (Math.Abs(i - n.i) < 0.0000001) && (Math.Abs(r - n.r) < 0.0000001);
        }

        public static bool operator ==(Complex a, Complex b)
        {
            if ((Math.Abs(a.i - b.i) < 0.0000001 && Math.Abs(a.r - b.r) < 0.0000001))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Complex a, Complex b)
        {
            if (Math.Abs(a.i - b.i) > 0.0000001 && Math.Abs(a.r - b.r) > 0.0000001)
            {
                return true;
            }
            return false;
        }
    }
}
