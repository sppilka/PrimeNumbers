using System;

namespace PrimeNumberMatrixGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter matrix size (1 - 10):");
            string value = Console.ReadLine();
            Console.WriteLine("");            

            bool isNumeric = int.TryParse(value, out int matrixSize);
            if (isNumeric)
            {
                try
                {
                    Matrix matrix = new Matrix(matrixSize);

                    Console.WriteLine($"Matrix size set to {value}...");
                    Console.WriteLine("");

                    matrix.Render();
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Matrix size {matrixSize} is out of range...");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unspecified error occured: {ex.Message}");
                }
            } else
            {
                Console.WriteLine($"The value {value} is invalid, please try again...");
            }                        
        }
    }
}
