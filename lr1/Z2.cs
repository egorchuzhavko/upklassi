using System;
using System.Collections.Generic;
using System.Text;

namespace lr1
{
    class Z2
    {
        private double x;
        private double y;
        private double z;

        public Z2() { }

        public Z2(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        ~Z2() { Console.WriteLine("Объект был удалён"); }

        public override string ToString() { return $"x={this.x} y={this.y} z={this.z}"; }

        public double average() { return (Math.Pow(x * y * z,1/3.0)); }

        public int countOfNumbers() { return Convert.ToString(x + y + z).Length; }
    }
}
