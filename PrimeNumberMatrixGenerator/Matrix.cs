using System;

namespace PrimeNumberMatrixGenerator
{
    public class Matrix : IMatrix
    {
        private int _n;
        private int[,] matrix;

        public Matrix(int n)
        {
            _n = n;

            CheckMatrixRange();
        }

        public bool CheckMatrixRange()
        {
            if (_n < 1 || _n > 10)
                throw new ArgumentOutOfRangeException();

            return true;
        }

        public void Render()
        {
            int[,] matrixValues = GetMatrixValues();

            for (int i = 0; i < matrixValues.GetLength(0); i++)
            {
                string a = string.Empty;
                for (int j = 0; j < matrixValues.GetLength(1); j++)
                {
                    int cell = matrixValues[i, j];
                    a += " " + cell.ToString().PadLeft(3, '0');
                }

                Console.WriteLine(a);
            }
        }

        private bool IsPrime(int n)
        {
            // Include 1 as prime
            if (n == 1 || n == 2)
                return true;

            if (n < 2 || n % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private int[,] GetMatrixValues()
        {
            matrix = new int[_n + 1, _n + 1];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    for (int j = _n; j < int.MaxValue; j++)
                    {
                        bool isPrime = IsPrime(j);
                        if (isPrime)
                        {
                            matrix[i, k] = j;
                            _n = j + 1;

                            break;
                        }
                    }
                }
            }

            return matrix;
        }
    }
}
