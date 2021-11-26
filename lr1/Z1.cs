using System;
using System.Collections.Generic;
using System.Text;

namespace lr1
{
    class Z1
    {
        private double r;
        private double rad;

        public Z1(double r, double rad)
        {
            this.r = r;
            this.rad = rad;
        }
        public double lengthDugi() { return r * rad; }
        public override string ToString() { return $"Радиус = {r}\nУгол в радианах = {rad}"; }
    }
}
