namespace PrimeNumberMatrixGenerator
{
    public interface IMatrix
    {
        /// <summary>
        /// Check if matrix size is in range
        /// </summary>
        /// <returns></returns>
        bool CheckMatrixRange();

        /// <summary>
        /// Render matrix to console
        /// </summary>
        void Render();
    }
}
