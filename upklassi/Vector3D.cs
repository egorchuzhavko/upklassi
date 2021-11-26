using System;
using System.Collections.Generic;
using System.Text;

namespace obwee
{
    class Vector3D
    {
        private double x;
        private double y;
        private double z;

        public Vector3D() { }
        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3D Add(Vector3D other) { return new Vector3D(this.x + other.x, this.y + other.y, this.z + other.z); }

        public Vector3D Sub(Vector3D other) { return new Vector3D(this.x - other.x, this.y - other.y, this.z - other.z); }

        public double scalarMultiply(Vector3D other) { return (this.x * other.x + this.y + other.y + this.z + other.z); }


        public Vector3D multiplyVectorOnScalar(double k) { return new Vector3D(this.x * k, this.y * k, this.z * k); }


        public double lengthOfVector() { return (Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2))); }


        public void lengthComparison(Vector3D other)
        {
            double thislen = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
            double otherlen = Math.Sqrt(Math.Pow(other.x, 2) + Math.Pow(other.y, 2) + Math.Pow(other.z, 2));
            if (thislen > otherlen)
                Console.WriteLine("Длина первого вектора больше длины второго вектора");
            else
                Console.WriteLine("Длина второго вектора больше длины первого вектора");
        }

        public void isEqual(Vector3D other)
        {
            if (this.x == other.x & this.y == other.y & this.z == other.z)
                Console.WriteLine("Векторы равны по координатам точек");
            else
                Console.WriteLine("Векторы не равны по координатам точек");
        }

        public override string ToString() { return $"x={this.x} y={this.y} z={this.z}"; }
    }
}
