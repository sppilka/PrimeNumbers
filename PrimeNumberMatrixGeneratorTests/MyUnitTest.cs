using System;
using Xunit;
using PrimeNumberMatrixGenerator;

namespace PrimeNumberMatrixGeneratorTests
{
    public class MyUnitTest
    {
        [Fact]
        public void CheckMatrixRange()
        {
            Matrix matrix = new Matrix(110);

            Assert.Throws<ArgumentOutOfRangeException>(
                () => matrix.CheckMatrixRange()    
            );
        }
    }
}
