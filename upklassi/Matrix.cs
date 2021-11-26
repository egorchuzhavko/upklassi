using System;
using System.Collections.Generic;
using System.Text;

namespace obwee
{
    class Matrix
    {
        private int n, m;
        private double[,] arr;

        public Matrix(double[,] arr)
        {
            this.arr = arr;
            n = arr.GetLength(0);
            m = arr.GetLength(1);
        }

        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;
            arr = new double[n, m];
        }

        public void fillMatrix()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    arr[i, j] = rnd.Next(1, 5);
        }
        public void Show()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }

        public static Matrix operator +(Matrix A, Matrix B)
        {
            Matrix res = new Matrix(A.n, A.m);
            for (int i = 0; i < A.n; i++)
                for (int j = 0; j < A.m; j++)
                    res.arr[i, j] = A.arr[i, j] + B.arr[i, j];
            return res;
        }

        public static Matrix operator -(Matrix A, Matrix B)
        {
            Matrix res = new Matrix(A.n, A.m);
            for (int i = 0; i < A.n; i++)
                for (int j = 0; j < A.m; j++)
                    res.arr[i, j] = A.arr[i, j] - B.arr[i, j];
            return res;
        }

        public static Matrix operator *(Matrix A, Matrix B)
        {
            Matrix res = new Matrix(A.n, A.m);
            for (int i = 0; i < res.n; i++)
                for (int j = 0; j < res.m; j++)
                    for (int k = 0; k < A.m; k++)
                        res.arr[i, j] += A.arr[i, k] * B.arr[k, j];
            return res;
        }

        public static Matrix operator *(Matrix A, double x)
        {
            Matrix res = new Matrix(A.n, A.m);
            for (int i = 0; i < A.n; i++)
                for (int j = 0; j < A.m; j++)
                    res.arr[i, j] = A.arr[i, j] * x;
            return res;
        }
    }
}
